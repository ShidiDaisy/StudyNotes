(function(){
  var app = angular.module('myreddit', ['ionic', 'angularMoment']);

//set up the controller(what data display in the view)

//call the controller function and create a controller name, use scope service
//In angularJS, whenever we want to use the service (eg.scope), just declare it as pararmeter into controller's function.
  app.controller('RedditCtrl', function($http, $scope){

    //http: make a http request
    //scope: allow us share variables between controller and view
    $scope.stories = [];

    function loadStories(params, callback){
      $http.get('https://www.reddit.com/r/funny/new/.json', {params: params}).success(function(response){
        var stories = [];
        angular.forEach(response.data.children, function(child){
          
          //append stories to the new array, different than $scope.stories
          stories.push(child.data);
        });

        //pass new stories
        callback(stories);
      });
    }

    $scope.loadMore = function(){
      
    //use "name" in json as before and after parameters
    //before: give me the items come before this object/new story
    //after: older story than this item

      var params = {};
      if ($scope.stories.length > 0){
        params['after'] = $scope.stories[$scope.stories.length - 1].name;
      }
      loadStories(params, function(olderStories){

        //concat: join two or more arrays
        $scope.stories = $scope.stories.concat(olderStories);
        $scope.$broadcast('scroll.infiniteScrollComplete');
      });
    };

    $scope.doRefresh = function(){
      var params = {'before': $scope.stories[0].name};
      loadStories(params, function(newerStories){
        $scope.stories = newerStories.concat($scope.stories);
        $scope.$broadcast('scroll.refreshComplete');
      });
    };
  });

  app.run(function($ionicPlatform) {
    $ionicPlatform.ready(function() {
      if(window.cordova && window.cordova.plugins.Keyboard) {
        cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
        cordova.plugins.Keyboard.disableScroll(true);
      }
      if(window.StatusBar) {
        StatusBar.styleDefault();
      }
    });
  });
}());