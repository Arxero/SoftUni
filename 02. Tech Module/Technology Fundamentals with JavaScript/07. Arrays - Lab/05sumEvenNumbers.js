function solution(input) {
    let result = 0
    for (let i = 0; i < input.length; i++) {
        if (+input[i] % 2 == 0) {
            result += +input[i]
        }
    }
    console.log(result)
}
