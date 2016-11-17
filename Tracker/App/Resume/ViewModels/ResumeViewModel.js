resumeModule.controller("resumeViewModel", function ($scope, resumeService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.resumeService = resumeService;

    var initialize = function () {
        $scope.refreshResume($routeParams.resumeId);
    }

    $scope.refreshResume = function (resumeId) {
        viewModelHelper.apiGet('api/resume/' + resumeId, null,
            function (result) {
                resumeService.resumeId = resumeId;
                $scope.resume = result.data;
            });
    }

    initialize();
});
