
var resumeModule = angular.module('resume', ['common']);

resumeModule.config(function ($routeProvider,
                                $locationProvider) {
    $routeProvider.when('resume', {
        templateUrl: '/App/Resume/Views/ResumeHomeView.html',
        controller: 'ResumeHomeViewModel'
    });

    $routeProvider.when('/resume/list', {
        templateUrl: '/App/Resume/Views/SkillsetListView.html',
        controller: 'resumeListViewModel'
    });

    $routeProvider.when('/resume/show/:resumeId', {
        templateUrl: '/App/Resume/Views/ResumeView.html',
        controller: 'resumeViewModel'
    });

    $routeProvider.otherwise({
        redirectTo: '/resume'
    });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});

resumeModule.factory('resumeService',
    function ($http, $location, viewModelHelper) {
        return MyApp.resumeService($http,
            $location, viewModelHelper);
    });

(function (myApp) {
    var resumeService = function ($http, $location,
        viewModelHelper) {

        var self = this;

        self.resumeId = 0;

        return this;
    };
    myApp.resumeService = resumeService;
}(window.MyApp));
