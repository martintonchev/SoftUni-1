function sortArray() {
    var array = arguments[0];
    var currentEl;
    var i;
    var j;
    for(i = 0; i < array.length - 1; i+=1) {
        for(j = i + 1; j < array.length; j+=1) {
            if(array[j] < array[i]) {
                currentEl = array[j];
                array[j] = array[i];
                array[i] = currentEl;
            }
        }
    }
    console.log(array);
}
sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);
