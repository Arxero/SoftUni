function solution(input) {
    let regexPattern = /[+359]{4}(\s|-)2\1[0-9]{3}\1[0-9]{4}\b/g
    let foundedNumbers = input[0].match(regexPattern)
    console.log(foundedNumbers.join(', '))
}
