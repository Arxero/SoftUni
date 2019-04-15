function solution(input, array) {
    let threeNumbersArray = []
    for (let i = 0; i < input; i++) {
        threeNumbersArray[i] = array[i]
    }
    let result = ''
    for (let i = input - 1; i >= 0; i--) {
        result += threeNumbersArray[i] + ' '
    }

    console.log(result)
}
solution(3, [10, 20, 30, 40, 50])