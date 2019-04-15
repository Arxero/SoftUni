function solution(input) {
    let result = []
    let smallerstNumbers = input.slice().sort((a, b) => a - b)
    let biggestNumbers = input.slice().sort((a, b) => b - a)

    for (let i = 0; i < input.length / 2; i++) {
        result.push(biggestNumbers[i])
        result.push(smallerstNumbers[i])
    }

    if (input.length % 2 != 0) {
        result.pop()
    }
    console.log(result.join(' '))
}
