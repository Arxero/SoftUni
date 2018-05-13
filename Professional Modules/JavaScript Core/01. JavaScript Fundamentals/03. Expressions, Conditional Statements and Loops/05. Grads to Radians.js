function convert(n){
 let degree = n * 3.6 / 4;
 degree %= 360;

 if (degree < 0) {
     degree = 360 + degree;
 }
console.log(degree);
}