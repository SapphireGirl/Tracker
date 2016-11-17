productModule.controller("skillsListViewModel", function ($scope, skillsService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.skillsService = skillsService;

    var initialize = function () {
        $scope.refreshProducts();
    }

    $scope.refreshProducts = function () {
        viewModelHelper.apiGet('api/skills', null,
            function (result) {
                $scope.products = result.data;
            });
    }

    $scope.showSkill = function (skills) {
        $scope.flags.shownFromList = true;
        viewModelHelper.navigateTo('skills/show/' + skills.SkillId);
    }

    initialize();
});
