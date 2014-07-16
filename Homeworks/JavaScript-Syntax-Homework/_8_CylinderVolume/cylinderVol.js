function calcCylinderVol(radius, height) {
    var volume = Math.round((Math.PI * Math.pow(radius, 2) * height) * 1000) / 1000;
    return volume;
}
console.log(calcCylinderVol(2, 4));
console.log(calcCylinderVol(5, 8));
console.log(calcCylinderVol(12, 3));

//Solution without hacks
function calcCylinderVol1(radius, height) {
    var volume = (Math.PI * Math.pow(radius, 2) * height).toFixed(3);
    return volume;
}
console.log(calcCylinderVol1(2, 4));
console.log(calcCylinderVol1(5, 8));
console.log(calcCylinderVol1(12, 3));
//# sourceMappingURL=app.js.map
