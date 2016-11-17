productModule.controller("rootViewModel", function ($scope, productService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    // This is the parent controller/viewmodel for 'skillsModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the Skills.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.skillsService = skillsService;

    $scope.flags = { shownFromList: false };

    var initialize = function () {
        $scope.pageHeading = "Skills Section";
    }

    $scope.productList = function () {
        viewModelHelper.navigateTo('skills/list');
    }

    $scope.showSkill = function () {
        if (skillsService.skillsetId !== 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo('skills/show/' + skillsService.skillsetId);
        }
    }

    initialize();
});
