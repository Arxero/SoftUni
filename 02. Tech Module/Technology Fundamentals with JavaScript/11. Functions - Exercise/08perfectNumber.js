function solution(input) {
    let sum = 0
    for (let i = input - 1; i >= 1; i--) {
        if (input % i == 0) {
            sum += i
        }
    }
    
    if (sum == input) {
        console.log('We have a perfect number!')
        return
    }
    console.log('It’s not so perfect.')
}