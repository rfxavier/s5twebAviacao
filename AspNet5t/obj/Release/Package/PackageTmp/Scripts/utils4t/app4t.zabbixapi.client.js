(function () {
    "use strict";

    var DX = window.DX || {};
    DX.Utils = DX.Utils || {};
    DX.Utils.version = DX.Utils.version ||
        function () {
            return "v1.0.0.9";
        };
    DX.Utils.getUrlParts = DX.Utils.getUrlParts ||
        function (url) {
            var parts = url.split(/[?#&]/),
                result = { url: parts[0] };

            parts.forEach(function (value, index) {
                if (index > 0) {
                    var pair = value.split("=", 2),
                        key = decodeURIComponent(pair[0]),
                        val = (pair.length > 1) ? decodeURIComponent(pair[1]) : "";
                    result[key] = val;
                }
            });
            return result;
        };
    DX.Utils.removeTrailingSlash = DX.Utils.removeTrailingSlash ||
        function (url) {
            var parts,
                result = "";
            if (url) {
                parts = url.split(/([?#])/);
                parts[0] = (parts[0][parts[0].length - 1] === '/') ? parts[0].substr(0, parts[0].length - 1) : parts[0];
                result = parts.join("");
            }
            return result;
        };
    DX.Utils.join = DX.Utils.join ||
        function (arr, separator, skipEmpty) {
            var result = '';
            if (arr && !skipEmpty) {
                result = arr.join(separator);
            }
            else {
                arr.forEach(function (value/*, index*/) {
                    var v = (value || '');
                    if (v.toString() !== '') {
                        result += (result !== '' ? separator : '') + v.toString();
                    }
                });
            }
            return result;
        };

    DX.WebAPI = DX.WebAPI || {};
    DX.WebAPI.Client = function (serviceUrl, actionEvents) {

        this.baseUrl = DX.Utils.removeTrailingSlash(serviceUrl);
        this.events = actionEvents || {};
        this.username = '';
        this.persistToken = false;
        this.data = {};
    };

    DX.WebAPI.Client.prototype = {
        dispatchEvents: function (handlers, eventArgs) {
            if (handlers) {
                handlers.forEach(function (element) {
                    if (element) {
                        element(eventArgs.args, eventArgs.sender);
                    }
                });
            }
        },
        coreAjax: function (method, url, headers, dataObj, onSuccess, onFailure) {
            var self = this,
                ajaxObj = {
                    method: method,
                    url: url,
                    contentType: 'application/json-rpc',
                    xhrFields: { withCredentials: false }
                };
            if (dataObj) {
                if (method == 'GET') {
                    ajaxObj = $.extend(ajaxObj, { data: dataObj }); 
                } else {
                    ajaxObj = $.extend(ajaxObj, { data: JSON.stringify(dataObj) });
                }
            }

            $.ajax(ajaxObj)
                .done(function (data) {
                    self.dispatchEvents([onSuccess], { sender: self, args: data });
                })
                .fail(function (err) {
                    self.dispatchEvents([onFailure], { sender: self, args: err });
                });
        },
        ajax: function (method, dataObj, onSuccess, onFailure) {
            var token = window[(this.persistToken ? 'local' : 'session') + 'Storage'].getItem(this.baseUrl + '_TOKEN'),
                url = this.baseUrl;

            if (token) {
                dataObj = $.extend(dataObj, { auth: token });
            };

            this.coreAjax(method, url, '', dataObj, onSuccess, onFailure);
        },
        post: function (dataObj) {
            var d = $.Deferred();
            this.ajax('POST', dataObj,
                function (data) {
                    d.resolve(data);
                },
                function (err, sender) {
                    d.reject(err);

                    if (!sender.authorizeError(err)) {
                        sender.dispatchEvents([sender.events.datasourceError], { sender: this, args: err });
                    }
                });
            return d.promise();
        },
        authorizeError: function (err) {
            var self = this;
            if (err.status === 401) {
                self.dispatchEvents([self.events.signinAction], { sender: self, args: err });
                return true;
            }
            else {
                return false;
            }
        },
        login: function (username, password, onSuccess, onFailure) {
            var self = this,
                loginData = {
                    "jsonrpc": "2.0",
                    "method": "user.login",
                    "params": {
                        "user": username,
                        "password": password
                    },
                    "id": 1,
                    "auth": null
                };
            $.ajax({
                type: 'POST',
                contentType: 'application/json-rpc',
                url: this.baseUrl,
                data: JSON.stringify(loginData)
            }).done(function (data) {
                self.username = data.userName;
                window[(this.persistToken ? 'local' : 'session') + 'Storage'].setItem(self.baseUrl + '_TOKEN', data.result);
                self.dispatchEvents([onSuccess, self.events.authenticatedAction], { sender: self, args: data });
            }).fail(function (err) {
                self.dispatchEvents([onFailure, self.events.accessDeniedAction], { sender: self, args: err });
            });
        },
        logout: function (logoutAction) {
            var self = this;

            window[(this.persistToken ? 'local' : 'session') + 'Storage'].removeItem(this.baseUrl + '_TOKEN');
            this.dispatchEvents([logoutAction, this.events.logoutAction], { sender: this, args: null });
            self.username = '';
        },
        authenticated: function () {
            var token = window[(this.persistToken ? 'local' : 'session') + 'Storage'].getItem(this.baseUrl + '_TOKEN');
            return (token !== '');
        }
    };

    window.DX = DX;
}());

