function createArray() {
    var array = new Array(20);
    var i;
    for(i = 0; i < array.length; i+=1) {
        array[i] = i * 5;
    }
    console.log(array);
}
createArray();
