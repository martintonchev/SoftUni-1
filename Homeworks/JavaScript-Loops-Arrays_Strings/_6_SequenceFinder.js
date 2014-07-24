function findMaxSequence() {
    var array = arguments[0];
    var current = 1;
    var max = 1;
    var maxNumber = array[0];
    var i;
    for(i = 0; i < array.length - 1; i+=1) {
        if(array[i] === array[i + 1]) {
            current++;
            if(max <= current) {
                max = current;
                maxNumber = array[i];
            }
        }
        else {
            current = 1;
        }
    }
    var resultArray = [];
    for(i = 0; i < max; i+=1) {
        resultArray.push(maxNumber);
    }
    console.log(resultArray);
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);