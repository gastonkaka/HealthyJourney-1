specialityModule.controller("infosViewModel", function ($scope, specialityService, $http, $q, $routeParams, $window, $location, viewModelHelper) {
    $scope.viewModelHelper = viewModelHelper;
    $scope.specialityService = specialityService;
    
    var infos = {};

    var initialize = function () {
      
      //  console.log("test" + specialityService.Id)
        $scope.refreshInfos($routeParams.id);
    }

    $scope.refreshInfos = function (Id) {
        viewModelHelper.apiGet('api/infos/' + $routeParams.id, null,
            function (result) {
                $scope.infos = result.data;
               $scope.specialityService.Id = $routeParams.id;

            });

    }
    

    initialize();
});
