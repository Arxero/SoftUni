function round([n, precision]){
    precision > 15 ? precision = 15 : precision;
    n = Number(n).toFixed(precision);
    console.log(Number(n));
}