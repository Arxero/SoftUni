function solution(input) {
    input.sort((a, b) => a - b)
    console.log(input.splice(0, 2).join(' '))
}
