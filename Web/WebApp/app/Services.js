angular.module('numericSequences').service(
    "NumericSequenceService",
    function ($http, $q) {
        // Return public API.
        return ({
            getAllNumbers: getAllNumbers,
            getAllOddNumbers: getAllOddNumbers,
            getAllEvenNumbers: getAllEvenNumbers,
            getCEZSequence: getCEZSequence,
            getFibonacciNumbers: getFibonacciNumbers,
        });

        function getAllNumbers(number) {
            var request = $http({
                method: "get",
                url: "api/sequenceservice/GetAllNumbers/" + number
            });

            return (request.then(handleSuccess, handleError));
        }
        
        function getAllOddNumbers(number) {
            var request = $http({
                method: "get",
                url: "api/sequenceservice/GetAllOddNumbers/" + number
            });

            return (request.then(handleSuccess, handleError));
        }

        function getAllEvenNumbers(number) {
            var request = $http({
                method: "get",
                url: "api/sequenceservice/GetAllEvenNumbers/" + number
            });

            return (request.then(handleSuccess, handleError));
        }

        function getCEZSequence(number) {
            var request = $http({
                method: "get",
                url: "api/sequenceservice/GetCEZSequence/" + number
            });

            return (request.then(handleSuccess, handleError));
        }

        function getFibonacciNumbers(number) {
            var request = $http({
                method: "get",
                url: "api/sequenceservice/GetFibonacciNumbers/" + number
            });

            return (request.then(handleSuccess, handleError));
        }

        // I transform the error response, unwrapping the application dta from
        // the API response payload.
        function handleError(response) {

            // The API response from the server should be returned in a
            // nomralized format. However, if the request was not handled by the
            // server (or what not handles properly - ex. server error), then we
            // may have to normalize it on our end, as best we can.
            if (
                !angular.isObject(response.data) ||
                !response.data.Message
                ) {

                return ($q.reject("An unknown error occurred."));

            }

            // Otherwise, use expected error message.
            return ($q.reject(response.data.Message));

        }

        // I transform the successful response, unwrapping the application data
        // from the API response payload.
        function handleSuccess(response) {

            return (response.data);

        }

    });