resumeModule.controller("rootViewModel",
    function ($scope, resumeService, $http, viewModelHelper) {

    // This is the parent controller/viewmodel for 'resumeModule' and its $scope is accesible
    // down controllers set by the routing engine. This controller is bound to the Resume.cshtml in the
    // Home view-folder.

    $scope.viewModelHelper = viewModelHelper;
    $scope.resumeService = resumeService;

    $scope.flags = { shownFromList: false };

    var initialize = function () {
        $scope.pageHeading = "Resume Section";
    }

    $scope.resumeList = function () {
        viewModelHelper.navigateTo('resume/list');
    }

    $scope.showResume = function () {
        if (resumeService.resumeId !== 0) {
            $scope.flags.shownFromList = false;
            viewModelHelper.navigateTo(
                'resume/show/' + resumeService.resumeId);
        }
    }

    initialize();
});
