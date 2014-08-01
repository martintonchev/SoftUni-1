function findLargestBySumOfDigits() {
    var inputArray = [];
    var sumOfDigits = 0;
    var maxSum = 0;
    var currentDigit = 0;
    var maxElIndex = 0;
    var additionalArray = [];
    var result = '';
    for (var i in arguments) {
        inputArray.push(arguments[i]);
    }
    for (var i in arguments) {
        additionalArray.push(arguments[i]);
    }
    for(var i in inputArray) {
        if(!isNaN(inputArray[i]) || !(inputArray[i] % 1 !== 0)) {
            if (inputArray[i] < 0) {
                inputArray[i] = -(inputArray[i]);
            }
            sumOfDigits = 0;
            var elementLength = inputArray[i].toString().length;
            for (var j = 0; j < elementLength; j += 1) {
                currentDigit = inputArray[i] % 10;
                sumOfDigits += currentDigit;
                if (sumOfDigits > maxSum) {
                    maxSum = sumOfDigits;
                    maxElIndex = i;
                }
                inputArray[i] = Math.floor(inputArray[i] / 10);
            }
        }
        else {
            result = "undefined";
        }
    }
    if(result === '') {
        console.log(additionalArray[maxElIndex]);
    }
    else {
        console.log(result);
    }
}
findLargestBySumOfDigits(5, 10, 15, 111);
findLargestBySumOfDigits(33, 44, -99, 0, 20);
findLargestBySumOfDigits('hello');
findLargestBySumOfDigits(5, 3.3);
