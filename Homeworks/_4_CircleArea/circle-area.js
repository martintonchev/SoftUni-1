function calc_circle_area(r) {
    var r;
    var area = Math.PI * Math.pow(r, 2);
    return area;
}
document.getElementById('area').innerHTML = "r = 7; area =" + calc_circle_area(7);
document.getElementById('second_area').innerHTML = "r = 1.5; area =" + calc_circle_area(1.5);
document.getElementById('third_area').innerHTML = "r = 20; area =" + calc_circle_area(20);