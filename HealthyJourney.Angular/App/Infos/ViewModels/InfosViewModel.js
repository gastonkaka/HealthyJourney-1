infosModule.controller("infosViewModel", function ($scope, infosService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.infosService = infosService;

    var initialize = function () {
      
        $scope.showInfos(infosService.Id);
    }


        $scope.showInfos = function (Id) {
            viewModelHelper.apiGet('api/infos/' + infosService.Id, null,
                function (result) {

                    $scope.infosService = result.data;
                    $scope.infos = infosService

                });
        }

    initialize();
});
