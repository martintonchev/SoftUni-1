function findMostFreqWord() {
    var inputArray = arguments[0].split(/\W+/);
    var currentCount = 1;
    var maxCount = 1;
    var maxElement = inputArray[0];
    for(var i = 0; i < inputArray.length; i+=1) {
        for(var j = 0; j < inputArray.length; j+=1) {
            if(inputArray[i] === inputArray[j] && i !== j) {
                currentCount++;
                maxElement = inputArray[i];
                if(currentCount > maxCount) {
                    maxCount = currentCount;

                }
            }
        }
        currentCount = 1;
    }
    console.log(maxElement+' -> '+ maxCount +' times');
}
findMostFreqWord('in the middle of the night');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');
