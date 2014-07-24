function reverseString() {
    var str = arguments[0];
    var arrayStr = str.split('');
    var i;
    var reversedArray = [];
    for(i = 0; i < arrayStr.length; i+=1) {
        reversedArray[i] = arrayStr[arrayStr.length- 1 - i];
    }
    console.log(reversedArray.join(''));
}
reverseString('sample');
reverseString('softUni');
reverseString('java script');