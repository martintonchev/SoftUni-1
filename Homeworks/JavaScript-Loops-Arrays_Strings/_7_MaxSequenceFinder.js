function findMaxSequence() {
    var array = arguments[0];
    var current = 1;
    var max = 1;
    var lastElIndex = 0;
    var i;
    var count = 0;
    for(i = 1; i < array.length; i+=1) {
        if(array[i] > array[i - 1]) {
            count = 1;
            current++;
            if(current > max) {
                max = current;
                lastElIndex = i;
            }
        }
        else {
            current = 1;
        }
    }
    if(count) {
        for(i = lastElIndex - max + 1; i <= lastElIndex; i+=1) {
            console.log(array[i]);
        }
    }
    else {
        console.log('No');
    }
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
console.log("----------------------")
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
console.log("----------------------")
findMaxSequence([3, 2, 1]);
