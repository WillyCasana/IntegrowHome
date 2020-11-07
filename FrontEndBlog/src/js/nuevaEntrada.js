app.controller('nuevaEntradaCller',function($scope,$http){
    $scope.guardarEntrada=function(entrada){
        console.log(entrada);
        $http({method:'POST', url:'https://localhost:44335/blog',data:entrada}).then(function successCallback(response){
            console.log(response.data);
        },function errorCallback(response){
            console.log('Error');
        });
    };
})