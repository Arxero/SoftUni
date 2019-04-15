function solution(input) {
    for (let i = 1; i <= input; i++) {
        let result = ''
        for (let k = 1; k <= i; k++) {
            result = result + i + ' '
        }
        console.log(result)
    }
}
