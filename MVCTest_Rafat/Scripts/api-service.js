var app = angular.module("myApp", ['ngRoute']);

app.config(function ($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('');
    $routeProvider
        .when("/", {
            templateUrl: "views/list.html",
            controller: 'myController'
        })
        .when("/add", {
            templateUrl: "views/addtask.html",
            controller: 'myController'
        });

});

app.controller("myController", function ($scope, $http, myService, $routeParams) {
    $scope.form = {};
    $scope.TaskID = '';
    var form1 = {
        "TaskID": $scope.TaskID
    }
    myService.getData().then(function (res) {
        $scope.tasks = res.data;
        console.log($scope.tasks);
    });

    $scope.submitForm = function () {
        alert($scope.form.TaskID);
        console.log(form1);
        //$http.post("http://localhost:49826/api/ToDoLists",$scope.form);
    }
});

app.service("myService", function ($http) {
    this.getData = function () {
        return $http.get("http://localhost:49826/api/ToDoLists");
    }

})