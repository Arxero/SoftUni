function solution(input) {
    let sum = 0
    for (let i = 1; i <= input; i++) {
        if (i % 2 != 0) {
            input++
            sum = sum + i
            console.log(i)
        }
    }
    console.log('Sum: ' + sum)
}
