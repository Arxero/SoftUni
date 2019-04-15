function solution(input) {
    let evenNumbersSum = 0
    let oddNumbersSum = 0

    for (let i = 0; i < input.length; i++) {
        if (input[i] % 2 == 0) {
            evenNumbersSum += input[i]
        } else {
            oddNumbersSum += input[i]
        }
    }
    console.log(evenNumbersSum - oddNumbersSum)
}
