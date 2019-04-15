function solution(input) {
    let result = []
    let currentNumber = 0

    for (let i = 0; i < input.length; i++) {
        if (input[i] >= currentNumber) {
            currentNumber = input[i]
            result.push(currentNumber)
        }
    }
    console.log(result.join(' '))
}

