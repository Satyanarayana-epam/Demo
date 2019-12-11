
var app = angular.module("employeeModule", []);

//Controller
var controller = app.controller("employeeController", ["$scope", "$http",
    function ($scope, $http) {// $scope and $http services
        $scope.newEmp = {
            selectedState: { Id: "1" },
            selectedCity: { Id: "1" }
        };

        var init = function () {

            //Using http service for api calls
            $http.get('/Employee/GetAllStates')
                .then(function (response) {
                    $scope.states = response.data;
                })
                .then(function (error) {

                });

            $http.get('/Employee/GetAllCities')
                .then(function (response) {
                    $scope.cities = response.data;
                })
                .then(function (error) {

                });

            $http.get('/Employee/GetAllEmployees')
                .then(function (response) {
                    $scope.employeeList = response.data;
                })
                .then(function (error) {

                });

        }();

        $scope.AddNewEmployee = function () {

            var cityName = $scope.cities.find(function (item) { return item.Id == $scope.newEmp.selectedCity }).CityName;
            var stateName = $scope.states.find(function (item) { return item.Id == $scope.newEmp.selectedState }).StateName;

            var emp = { FirstName: $scope.newEmp.FirstName, LastName: $scope.newEmp.LastName, Age: $scope.newEmp.Age, City: cityName, State: stateName }

            // Adding new item to list and which reflects in view.
            $scope.employeeList.push(emp);

            $scope.newEmp = {
                selectedState: { Id: "1" },
                selectedCity: { Id: "1" }
            };

        }
    }]);