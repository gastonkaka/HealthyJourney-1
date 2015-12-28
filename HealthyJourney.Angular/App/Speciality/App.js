
var specialityModule = angular.module('speciality', ['common'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/speciality', { templateUrl: '/App/Speciality/Views/SpecialityHomeView.html', controller: 'specialityHomeViewModel' });
        $routeProvider.when('/speciality/list', { templateUrl: '/App/Speciality/Views/SpecialityListView.html', controller: 'specialityListViewModel' });
        $routeProvider.when('/speciality/show/:id', { templateUrl: '/App/Speciality/Views/SpecialityView.html', controller: 'specialityViewModel' });
        $routeProvider.when('/infos/show/:id', { templateUrl: '/App/Speciality/Views/InfosView.html', controller: 'infosViewModel' });
        $routeProvider.otherwise({ redirectTo: '/speciality' });
        $locationProvider.html5Mode(true);
    });

specialityModule.factory('specialityService',
    function ($rootScope, $http, $q, $location, viewModelHelper)
    {
        return MyApp.specialityService($rootScope, $http, $q, $location, viewModelHelper);
    });


(function (myApp) {
    var specialityService = function ($rootScope, $http, $q, $location, viewModelHelper) {

        var self = this;

        self.Id = 0;

        return this;
    };
   

    myApp.specialityService = specialityService;
}(window.MyApp));
