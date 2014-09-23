'use strict';

/* Controllers */

var app = angular.module('app', []);

app.controller('ClassListController', function ($scope) {
    $scope.ScheduledClasses = [
      {
          'ClassID' : 1,
          'ClassName': 'Class 1',
          'ClassDate': '2014-10-10 10:00 AM',
          'Instructor' : 'Eric'
      },
      {
          'ClassID': 2,
          'ClassName': 'Class 2',
          'ClassDate': '2014-10-10 11:00 AM',
          'Instructor': 'David'
      }
    ];
});
