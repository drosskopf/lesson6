angular.module('cool',[]).controller('coolController',['$http',function($http){
    var vm = this;
    vm.family={};
    vm.addFamily=function(){
        $http.get('/Family/Get').then(
            function(response){
             vm.family=response.data;
            },
            function(error){
             console.log(error);
            }
        )
        
    }
}])