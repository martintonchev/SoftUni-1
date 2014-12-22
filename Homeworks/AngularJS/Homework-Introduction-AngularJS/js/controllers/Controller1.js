app.value('studentInfo', {
        "name": "Pesho",
        "photo": "http://www.nakov.com/wp-content/uploads/2014/05/SoftUni-Logo.png",
        "grade": 5,
        "school": "High School of Mathematics",
        "teacher": "Gichka Pesheva"
    }
);
app.controller('Controller1', function ($scope, studentInfo) {
    $scope.student = studentInfo;
});
