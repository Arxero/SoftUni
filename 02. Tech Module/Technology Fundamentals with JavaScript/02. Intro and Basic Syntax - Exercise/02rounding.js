function solution(number, precision) {
    if (precision > 15) {
        precision = 15
    }
    let result = number.toFixed(precision)
    console.log(parseFloat(result))
}
