function solution(input) {
    let devisibleNumber = 0
    if (input % 10 == 0) {
        devisibleNumber = 10
    } else if (input % 7 == 0) {
        devisibleNumber = 7
    } else if (input % 6 == 0) {
        devisibleNumber = 6
    } else if (input % 3 == 0) {
        devisibleNumber = 3
    } else if (input % 2 == 0) {
        devisibleNumber = 2
    }

    if (devisibleNumber != 0) {
        console.log(`The number is divisible by ${devisibleNumber}`)
    } else {
        console.log('Not divisible')
    }
}
