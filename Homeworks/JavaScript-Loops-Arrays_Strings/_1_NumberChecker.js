function printNumbers(num) {
    if (num < 0) {
        console.log("no")
    }
    else {
        var str = 1;
        for (var i = 2; i <= num; i++) {
            if (i % 4 == 0 || i % 5 == 0) {
                continue;
            }
            str += ', ' + +i;
        }
        console.log(str);
    }
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);

