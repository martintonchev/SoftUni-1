function findMinAndMax(num) {
    var max = Math.max(num[0]);
    var min = Math.min(num[0]);
    for (var i = 0; i < num.length; i++) {
        if (max > num[i]) {
            max = num[i];
        }
        if (min < num[i]) {
            min = num[i];
        }
    }
    console.log("Min -> " + min);
    console.log("Max -> " + max);
}
findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
