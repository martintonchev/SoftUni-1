function isPrime(value) {
    for (var i = 2; i <= Math.sqrt(value); i++) {
        if ((value % i) == 0) {
            var prime = false;
            break;
        } else {
            var prime = true;
        }
    }
    return prime;
}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
//# sourceMappingURL=app.js.map
