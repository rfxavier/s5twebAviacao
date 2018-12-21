/// <reference path="../js/jquery-1.11.3.min.js" />
/// <reference path="../js/knockout-3.4.0.js" />
/// <reference path="../js/dx.all.js" />

(function () {
    function createWebAPIClient(applicationObj, serviceUrl) {
        var actionEvents = {
            signinAction: function (args, sender) {
                console.log('signin action');
            },
            authenticatedAction: function (args, sender) {
                console.log('authenticated action');
            },
            externalAuthenticatedAction: function (args, sender) {

            },
            externalRegisteredAction: function (args, sender) {

            },
            externalRegisterErrorAction: function (args, sender) {

            },
            providersPopulatedAction: function (args, sender) {

            },
            logoutAction: function (args, sender) {

            }
        };

        var result = new DX.WebAPI.Client(serviceUrl, actionEvents);
        result.owner = applicationObj;

        return result;
    }
    window.App4t.db = createWebAPIClient(App4t, zabbix.endpoint);
}());
