function solution(input) {
    let sum = 0
    input.toString().split('').map(n => sum += +n)
    if (sum.toString().includes(9)) {
        console.log(input + ' Amazing? True')
    } else {
        console.log(input + ' Amazing? False')
    }
}
