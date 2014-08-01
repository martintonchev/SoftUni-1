function findNthDigit(arr) {
    var digitCount = arr[0];
    var number = arr[1];
    var result = '';
    while(number % 1 !== 0) {
        number = number * 10;
    }
    if(number < 0) {
        number = -(number);
    }
    var numberCount = number.toString().length;
    for (var i = 0; i < digitCount - 1; i+=1) {
        if(numberCount < digitCount) {
            result = "The number doesnt have " + digitCount +" digits";
            break;
        }
        number = Math.floor(number / 10);
    }
    number = number % 10;
    if (result == '') {
        console.log(number);
    }
    else {
        console.log(result);
    }
}
findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);

