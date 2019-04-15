function solution(input) {
    let regexPattern = /\b[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\b/g
    let foundNames = input[0].match(regexPattern)
    console.log(foundNames.join(' '))
}