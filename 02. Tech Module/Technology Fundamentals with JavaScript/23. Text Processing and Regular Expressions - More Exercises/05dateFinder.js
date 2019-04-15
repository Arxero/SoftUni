function solution(input) {
    let pattern = /\b[0-9]{2}-[A-Z][a-z]{2}-[0-9]{4}\b/g
    let matches = []

    while ((matches = pattern.exec(input)) !== null) {
        console.log(matches[0].replace(/-/g, ' '))
    }
}