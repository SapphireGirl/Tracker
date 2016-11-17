resumeModule.controller("resumeListViewModel",
    function ($scope, resumeService, $http, $q, $routeParams,
        $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    $scope.resumeService = resumeService;

    var initialize = function () {
        $scope.refreshresume();
    }

    $scope.refreshResumes = function () {
        viewModelHelper.apiGet('api/resumes', null,
            function (result) {
                $scope.resumes = result.data;
            });
    }

    $scope.showResume = function (resume) {
        $scope.flags.shownFromList = true; // note this object is declared in the RootViewModel
        viewModelHelper.navigateTo('resume/show/' + resume.ResumeId);
    }

    initialize();
});
