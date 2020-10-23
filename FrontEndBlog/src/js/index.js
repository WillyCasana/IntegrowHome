var app = angular.module('BlogApp',['ui.router']);
app.controller('BlogAppCller',function($scope){
    $scope.guardarEntrada=function(valores){
        console.log(valores);
    }
})
app.config(function($stateProvider){
    var nuevaEntrada={
        name:'nuevaE',
        url:'/nuevaE',
        controller:'nuevaEntradaCller',
        templateUrl: './views/nuevaEntrada.html'
    }
    var listadoEntrada={
        name:'listadoE',
        url:'/listadoE',
        templateUrl: './views/listadoEntrada.html'
    }

    var listadoEntradaDetalle={  //contenido del articulo(blog)
        name:'listadoEDetalle',
        url:'/listadoEDetalle',
        templateUrl:'./views/listadoEntradaDetalle.html'
    }

    $stateProvider.state(nuevaEntrada);
    $stateProvider.state(listadoEntrada);
    $stateProvider.state(listadoEntradaDetalle);
})