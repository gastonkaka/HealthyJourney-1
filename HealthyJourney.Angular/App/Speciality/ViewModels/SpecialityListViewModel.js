specialityModule.controller("specialityListViewModel", function ($scope, specialityService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.specialityService = specialityService;

    var initialize = function () {
        $scope.refreshSpecialities();
    }

    $scope.refreshSpecialities = function () {
        viewModelHelper.apiGet('api/speciality', null,
            function (result) {
                $scope.specialities = result.data;
                $scope.specialityService = specialityService;
            });
    }

    $scope.showSpeciality = function (speciality) {
        $scope.flags.shownFromList = true;
        $scope.specialityService.Id = speciality.Id;
        viewModelHelper.navigateTo('speciality/show/' + speciality.Id);
    }

    initialize();
});
