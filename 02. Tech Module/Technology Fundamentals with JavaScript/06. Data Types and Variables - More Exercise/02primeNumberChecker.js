function solution(input) {
    for (let i = 2; i < input; i++) {
        if (input % i == 0 || (input == 1 || input == 0)) {
            console.log(false)
            return
        } else {
            console.log(true)
            return
        }
    }
}
