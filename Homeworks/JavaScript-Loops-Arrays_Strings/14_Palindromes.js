function findPalindromes() {
    var inputArray = arguments[0].split(/\W+/);
    var resultString = '';
    var resultArray = [];
    for(var element in inputArray) {
        var currentElement = inputArray[element].toLowerCase();
        resultString = currentElement.split('').reverse().join('');
        if(currentElement === resultString) {
            resultArray.push(currentElement);
        }
    }
    console.log(resultArray.join(', '));
}
findPalindromes('There is a man, his name was Bob.');