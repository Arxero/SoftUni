function solution(n1, n2, n3) {
    let sumNumbers = (a, b) => a + b
    let subtractNumbers = x => x - n3
    console.log(subtractNumbers(sumNumbers(n1, n2)))
}
