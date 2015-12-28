infosModule.controller("infosListViewModel", function ($scope, infosService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.infosService = infosService;


    var initialize = function () {
        $scope.showAllInfos();
    }
    
    $scope.showAllInfos = function () {
        viewModelHelper.apiGet('api/infos', null,
            function (result) {
                $scope.infos = result.data;
                $scope.infosService = infosService;
            });
    }

    $scope.showInfos = function (infos) {
        $scope.flags.shownFromList = true;
        viewModelHelper.navigateTo('infos/show/' + infos.UserId);
        $scope.infosService.Id = infos.UserId;

    }


    initialize();
});
