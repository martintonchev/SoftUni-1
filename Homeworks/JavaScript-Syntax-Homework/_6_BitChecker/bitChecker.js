function bitChecker(value) {
    var thirdBit = (value >> 3) & 1;
    if (thirdBit) {
        return true;
    } else {
        return false;
    }
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));
//# sourceMappingURL=app.js.map
