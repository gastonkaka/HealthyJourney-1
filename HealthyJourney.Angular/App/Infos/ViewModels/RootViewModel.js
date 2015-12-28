infosModule.controller("rootViewModel", function ($scope, infosService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    // This is the parent controller/viewmodel for 'specialityModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the speciality.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.infosService = infosService;

    $scope.flags = { shownFromList: false };

    var initialize = function () {
        $scope.pageHeading = "infos Section";
    }

    $scope.showAllInfos = function () {
        viewModelHelper.navigateTo('infos/list');
    }

    $scope.showInfos = function () {
        if (infosService.Id != 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo('infos/show/' + infosService.Id);
        }
    }

    initialize();
});
