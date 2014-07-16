//# sourceMappingURL=app.js.map
function roundNUmber(value) {
    var rounded = Math.round(value);
    var floored = Math.floor(value);
    return rounded + '\n' + floored;
}

console.log(roundNUmber(22.7));
console.log(roundNUmber(12.3));
console.log(roundNUmber(58.7));