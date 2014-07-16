function calcSupply(currentAge, maxAge, dosePerDay) {
    var supply = ((maxAge - currentAge) * 365 * dosePerDay);
    return supply;
}
console.log(calcSupply(38, 118, 0.5) + "kg of chocalate would be enpugh until I am 118 years old");
console.log(calcSupply(20, 87, 2) + "kg of fruits would be enpugh until I am 87 years old");
console.log(calcSupply(16, 102, 1.1) + "kg of nuts would be enpugh until I am 102 years old");
//# sourceMappingURL=app.js.map
