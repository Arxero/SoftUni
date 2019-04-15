function solution(input) {
    let pattern = /[A-Z][a-z]*/g
    let foundPascalCase = input.match(pattern)
    console.log(foundPascalCase.join(', '))
}
