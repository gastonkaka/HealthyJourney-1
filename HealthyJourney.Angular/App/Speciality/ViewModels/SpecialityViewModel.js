specialityModule.controller("specialityViewModel", function ($scope, specialityService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.specialityService = specialityService;

    var initialize = function () {
      
        console.log("test" + specialityService.Id)
        $scope.refreshSpeciality(specialityService.Id);
    }

    $scope.showInfos = function (Id) {
        $scope.flags.shownFromList = true;
        $scope.specialityService.Id = Id;
       
        viewModelHelper.navigateTo('infos/show/' + Id);

    }


        $scope.showSpecialityInfos = function (speciality) {
        viewModelHelper.apiGet('api/speciality/' + specialityService.Id +'/providers', null,
            function (result) {
                $scope.providers = result.data;
                
            });
        }
        $scope.refreshSpeciality = function (Id) {
            viewModelHelper.apiGet('api/speciality/' + specialityService.Id, null,
                function (result) {

                    $scope.specialityService = result.data;
                    $scope.speciality = specialityService

                });
        }

    initialize();
});
