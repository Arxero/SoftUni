function solution(input) {
    let sum = input % 10
    while (parseInt(input / 10) > 0) {
        input = parseInt(input / 10)
        sum += input % 10
    }
    console.log(sum)
}
