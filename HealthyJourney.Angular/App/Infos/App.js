
var infosModule = angular.module('infos', ['common'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/infos', { templateUrl: '/App/Infos/Views/InfosHomeView.html', controller: 'infosHomeViewModel' });
        $routeProvider.when('/infos/list', { templateUrl: '/App/Infos/Views/InfosListView.html', controller: 'infosListViewModel' });
        $routeProvider.when('/infos/show/:id', { templateUrl: '/App/Infos/Views/InfosView.html', controller: 'infosViewModel' });
        $routeProvider.otherwise({ redirectTo: '/infos' });
        $locationProvider.html5Mode(true);
    });

infosModule.factory('infosService',
    function ($rootScope, $http, $q, $location, viewModelHelper)
    {
        return MyApp.infosService($rootScope, $http, $q, $location, viewModelHelper);
    });


(function (myApp) {
    var infosService = function ($rootScope, $http, $q, $location, viewModelHelper) {

        var self = this;

        self.UserId = "";

        return this;
    };
   

    myApp.infosService = infosService;
}(window.MyApp));
