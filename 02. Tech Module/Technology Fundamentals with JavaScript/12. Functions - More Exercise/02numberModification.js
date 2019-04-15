function solution(input) {
    input = input.toString().split('').map(x => +x)
    let sum = 0
    input.map(x => sum += x)
    let count = input.length

    while (sum / count <= 5) {
        input.push(9)
        sum = 0
        input.map(x => sum += x)
        count = input.length
    }

    console.log(input.join(''))
}
