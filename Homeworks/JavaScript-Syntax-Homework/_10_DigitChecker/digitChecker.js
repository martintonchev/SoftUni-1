function checkDigit(num) {
    num = Math.floor(num / 100);
    if ((num % 10) == 3) {
        return true;
    }
    else {
        return false;
    }
}
console.log(checkDigit(1234));
console.log(checkDigit(25368));
console.log(checkDigit(123456));
