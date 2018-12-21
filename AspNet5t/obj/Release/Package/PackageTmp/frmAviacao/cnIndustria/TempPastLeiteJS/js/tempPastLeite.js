window.onload = function () {
    var dataSource = ko.observableArray([]);

    var d = $.Deferred();

    var viewModel = {
        texto: zabbix.endpoint,
        horasAtras: ko.observable(4),
        tempAtual: ko.observable(0),
        horaAtual: ko.observable(''),
        dataSource: dataSource,
        chartOptions: {
            palette: "violet",
            dataSource: dataSource,
            useAggregation: false,
            commonSeriesSettings: {
                argumentField: "clockDate",
                type: "line"
            },
            margin: {
                bottom: 20
            },
            argumentAxis: {
                valueMarginsEnabled: false,
                discreteAxisDivisionMode: "crossLabels",
                grid: {
                    visible: true
                },
                label: {
                    overlappingBehavior: { mode: 'enlargeTickInterval' },
                    customizeText: function () {
                        return (this.value).hhmm();
                    }
                }
            },
            series: [
                {
                    valueField: "value",
                    name: "Temp.Past.Leite",
                    point: { visible: false },
                    tagField: "data"
                },
            ],
            legend: {
                verticalAlignment: "bottom",
                horizontalAlignment: "center",
                itemTextPosition: "bottom",
                visible: false
            },
            valueAxis: {
                grid: {
                    visible: false
                },
                label: {
                    customizeText: function () {
                        return Number(this.value).formatMoney(1, ',', '.');
                    }
                },
                valueType: 'numeric',
                min: 0,
                max: 100,
                tickInterval: 10
            },
            title: {
                text: "Temperatura Pasteurização Leite",
                subtitle: {
                    text: "(° Celsius)"
                }
            },
            "export": {
                enabled: true
            },
            tooltip: {
                enabled: true,
                customizeTooltip: function (arg) {
                    //console.log(arg.point.tag);
                    //return {
                    //    text: Number(arg.valueText).formatMoney(1, ',', '.')
                    //};

                    var node = $("<div>")
                        .append("<div>" + 'Data: ' + arg.point.tag.clockDDMMYYYY + "</div>")
                        .append("<div>" + 'Hora: ' + arg.point.tag.clockHHMM + "</div>")
                        .append("<div>" + 'Temperatura: <b>' + arg.point.tag.valueTemperatura + "</b></div>")


                    return {
                        html: node.html()
                    };
                }
            }
        }
    };

    viewModel.numberboxOptions = {
        min: 1,
        max: 6,
        showSpinButtons: true,
        readOnly: false,
        mode: 'number',
        width: '60px',
        value: viewModel.horasAtras,
        onValueChanged: function (e) {
            atualizaDataSourceChart();
        }
    };

    viewModel.gaugeTitulo = ko.computed(function () {
        return "Temperatura Atual às " + viewModel.horaAtual();
    });

    viewModel.gaugeValueDisplay = ko.computed(function () {
        return Number(viewModel.tempAtual()).formatMoney(1, ',', '.') + '° C';
    });

    viewModel.gaugeOptions = {
        scale: {
                startValue: 0,
                endValue: 100,
                tickInterval: 10,
                label: {
                    useRangeColors: true
                }
        },
        valueIndicator: {
            type: 'twoColorNeedle'
        },
        rangeContainer: {
                palette: "pastel",
                ranges: [
                    { startValue: 30, endValue: 60 },
                    { startValue: 60, endValue: 90 },
                    { startValue: 90, endValue: 100 }
                ]
        },
        title: {
            text: viewModel.gaugeTitulo,
            font: { size: 18 },
            subtitle: viewModel.gaugeValueDisplay
        },
            "export": {
                enabled: true
            },
        value: viewModel.tempAtual
    };

    viewModel.nowTimestamp = ko.computed(function () {
        return Math.round(new Date().getTime() / 1000)

    });

    viewModel.nowTimestampHorasAtras = ko.computed(function () {
        var d = new Date();

        d.setHours(d.getHours() - viewModel.horasAtras());

        return Math.round(d.getTime() / 1000)
    });


    var atualizaDataSourceChart = function () {
        App4t.db.post({
            "jsonrpc": "2.0",
            "method": "history.get",
            "params": {
                "output": "extend",
                "history": "0",
                "itemids": [
                  "25527"
                ],
                "sortfield": "clock",
                "sortorder": "ASC",
                "time_from": viewModel.nowTimestampHorasAtras(),
                "time_till": viewModel.nowTimestamp()
            },
            "id": 1
        })
        .done(function (data) {
            console.log(data);
            console.log(viewModel.nowTimestamp());
            console.log(viewModel.nowTimestampHorasAtras());

            var dataArray = [];

            for (var i = 0; i < data.result.length; i++) {
                $.extend(data.result[i], {
                    clockDate: new Date((data.result[i].clock) * 1000),
                    clockHHMM: new Date((data.result[i].clock) * 1000).hhmm(),
                    data: {
                        clockDDMMYYYY: new Date((data.result[i].clock) * 1000).ddmmyyyy(),
                        clockHHMM: new Date((data.result[i].clock) * 1000).hhmm(),
                        valueTemperatura: Number(data.result[i].value).formatMoney(1, ',', '.') + '° C'
                    }
                });

                dataArray.push(data.result[i]);
            };

            viewModel.dataSource(dataArray);
            viewModel.chartOptions.dataSource(viewModel.dataSource());
            console.log(dataArray);

            viewModel.tempAtual(dataArray[dataArray.length - 1].value);
            viewModel.horaAtual(dataArray[dataArray.length - 1].clockHHMM);
            //console.log(viewModel.tempAtual());
            //console.log(viewModel.horaAtual());
        });
    };

    App4t.db.login(zabbix.userCredentials.user, zabbix.userCredentials.password);

    atualizaDataSourceChart();

    ko.applyBindings(viewModel, document.getElementById("app4t"));
};


