function findMostFreqNum() {
    var array = arguments[0];
    var maxNum;
    var currentCount = 0;
    var maxCount = 0;
    var i, j;
    for(i = 0; i < array.length; i+=1) {
        for(j = 0; j < array.length; j+=1) {
            if(array[i] === array[j]) {
                currentCount++;
                if(currentCount > maxCount) {
                    maxCount = currentCount;
                    maxNum=array[i];
                }
            }
        }
        currentCount = 0;
    }
    console.log(maxNum + "(" + maxCount +" times)");
}
findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);
