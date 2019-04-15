function solution(input) {
    input = input.toString().split('').map(x => +x)
    let evenNumbers = input.filter((x) => x % 2 == 0)
    let oddNumbers = input.filter((x) => x % 2 != 0)
    let evenSum = evenNumbers.reduce((a, b) => a + b, 0)
    let oddSum = oddNumbers.reduce((a, b) => a + b, 0)
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}
solution(1000435)