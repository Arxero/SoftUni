function nextDay(year, month, day){
let date = new Date(year,month - 1,day);
let nextDay = new Date(date.getTime() + 86400000);//one day in milliseconds
console.log(`${nextDay.getFullYear()}-${nextDay.getMonth() + 1}-${nextDay.getDate()}`);
}