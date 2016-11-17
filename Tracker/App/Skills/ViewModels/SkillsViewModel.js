productModule.controller("skillsViewModel", function ($scope, skillsService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.skillsService = skillsService;

    var initialize = function () {
        $scope.refreshSkills($routeParams.skillsetId);
    }

    $scope.refreshProduct = function (skillsetId) {
        viewModelHelper.apiGet('api/skills/' + skillsetId, null,
            function (result) {
                skillsService.skillsetId = skillsetId;
                $scope.product = result.data;
            });
    }

    initialize();
});
