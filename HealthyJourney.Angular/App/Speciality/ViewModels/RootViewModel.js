specialityModule.controller("rootViewModel", function ($scope, specialityService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    // This is the parent controller/viewmodel for 'specialityModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the speciality.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.specialityService = specialityService;

    $scope.flags = { shownFromList: false };

    var initialize = function () {
        $scope.pageHeading = "speciality Section";
    }

    $scope.specialityList = function () {
        viewModelHelper.navigateTo('speciality/list');
    }

    $scope.showSpeciality = function () {
        if (specialityService.Id != 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo('speciality/show/' + specialityService.Id);
        }
    }

    $scope.showInfos = function () {
        if (specialityService.Id != 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo('infos/show/' + specialityService.Id);
        }
    }

    initialize();
});
