function solution(a, b, c) {
    let result = [a, b, c].reduce((a, b) => a > b ? a : b)
    console.log(result)
}
