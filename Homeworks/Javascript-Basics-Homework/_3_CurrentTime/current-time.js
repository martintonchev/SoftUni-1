var current_date = new Date();
var formated_day = current_date.getDate();
if (formated_day < 10) {
    formated_day = "0" + formated_day;
}
var current_time = current_date.getMonth()+1 + ":" + formated_day;
console.log(current_time);