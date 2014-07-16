function treeHouseCompare(houseSize, treeSize) {
    var houseArea = Math.pow(houseSize, 2) + (((2 / 3) * houseSize) * houseSize) / 2;
    var treeArea = treeSize * treeSize / 3 + Math.pow((2 / 3 * treeSize), 2) * Math.PI;
    if (houseArea > treeArea) {
        return "house/" + houseArea.toFixed(2);
    } else {
        return "tree/" + treeArea.toFixed(2);
    }
}
console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));
//# sourceMappingURL=app.js.map
