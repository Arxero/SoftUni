function solution(input) {
    let step = +input.pop()
    let result = ''

    for (let i = 0; i < input.length; i += step) {
        result += input[i] + ' '
    }
    console.log(result.trim())
}
