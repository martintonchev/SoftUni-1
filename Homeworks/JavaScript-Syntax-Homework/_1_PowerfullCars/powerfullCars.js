function horsePowersConverter(kilowats) {
    var hp = Math.round(kilowats / 0.745699872 * 100) / 100;
    return hp;
}

console.log(horsePowersConverter(75));
console.log(horsePowersConverter(150));
console.log(horsePowersConverter(1000));

//Solution without hacks for decimal point position
function hpConvertor(kilowats) {
    var hp = kilowats / 0.745699872;
    hp.toFixed(2);
    return hp;
}

console.log(horsePowersConverter(75));
console.log(horsePowersConverter(150));
console.log(horsePowersConverter(1000));
//# sourceMappingURL=app.js.map
//# sourceMappingURL=app.js.map
