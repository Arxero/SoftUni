function solution(input) {
    let result = []
    input.forEach(x => {
        if (x >= 0) {
            result.push(x)
            return
        }
        result.unshift(x)
    })

    console.log(result.join('\n'))
}
