function solution(input) {
    input = JSON.parse(input)
    let result = Object.entries(input)

    for (let [key, value] of result) {
        console.log(key + ': ' + value)
    }
}
