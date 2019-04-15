function solution(input) {
    let result = []

    for (let i = 0; i < input.length; i++) {
        let currentNumber = input[i + 1]

        for (let k = i + 1; k < input.length; k++) {
            if (input[k + 1] >= currentNumber) {
                currentNumber = input[k + 1]
            }
        }
        if (!result.includes(currentNumber)) {
            result.push(currentNumber)
        }
    }

    console.log(result.join(' '))
}
