app.value('tigerInfo', {
    name: 'Pesho',
    born: 'Asia',
    birthData: 2006,
    live: 'Sofia Zoo',
    url: 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg'
})
.controller('Controller3', function ($scope, tigerInfo) {
    $scope.tiger = tigerInfo;
});
