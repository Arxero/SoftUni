function solution(input, substring) {
    let regexPattern = new RegExp (substring, 'gi')
    let matches = input.match(regexPattern)

    if (matches) {
        console.log(matches.length)
        return
    }
    console.log(0)
}