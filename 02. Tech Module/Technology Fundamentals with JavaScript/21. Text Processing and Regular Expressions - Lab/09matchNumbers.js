function solution(input) {
    let regexPattern = /(^|(?<=\s))-?[0-9]+\.?([0-9]+)?($|(?=\s))/g
    let foundNumbers = input[0].match(regexPattern)
    console.log(foundNumbers.join(' '))
}
