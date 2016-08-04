(function () {
    'use strict';
    var app = angular.module('numericSequences', ['ngMessages']);

    app.controller('SequencesController', function ($scope, NumericSequenceService) {

        refreshValues();

        function refreshValues() {
            $scope.errorAll = "";
            $scope.AllNumbers = "";
            $scope.errorOdd = "";
            $scope.AllOddNumbers = "";
            $scope.errorEven = "";
            $scope.AllEvenNumbers = "";
            $scope.errorCEZ = "";
            $scope.CEZSequence = "";
            $scope.errorFibonacci = "";
            $scope.FibonacciNumbers = "";
        }

        $scope.submitForm = function () {

            refreshValues();

            var val = parseInt($scope.input);

            $scope.sequencesForm.input.$setValidity("ValidInteger", true);

            if ($scope.sequencesForm.$valid) $scope.sequencesForm.input.$setValidity("ValidInteger", (val <= 2147483646));

            if ($scope.sequencesForm.$valid) {
                
                NumericSequenceService.getAllNumbers($scope.input)
                    .then(
                            function (data) { $scope.AllNumbers = data; },
                            function (error) { $scope.errorAll = error; }
                    );

                NumericSequenceService.getAllOddNumbers($scope.input)
                    .then(
                            function (data) { $scope.AllOddNumbers = data; },
                            function (error) { $scope.errorOdd = error; }
                    );

                NumericSequenceService.getAllEvenNumbers($scope.input)
                    .then(
                            function (data) { $scope.AllEvenNumbers = data; },
                            function (error) { $scope.errorEven = error; }
                    );

                NumericSequenceService.getCEZSequence($scope.input)
                    .then(
                            function (data) { $scope.CEZSequence = data; },
                            function (error) { $scope.errorCEZ = error; }
                    );

                NumericSequenceService.getFibonacciNumbers($scope.input)
                    .then(
                            function (data) { $scope.FibonacciNumbers = data; },
                            function (error) { $scope.errorFibonacci = error; }
                    );
            }             
        }
    });
})();
