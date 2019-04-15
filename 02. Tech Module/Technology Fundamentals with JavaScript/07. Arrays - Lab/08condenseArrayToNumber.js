function solution(input) {
    let condensed = []
    
    while (input.length > 1) {
        for (let i = 0; i < input.length; i++) {
            if (typeof input[i + 1] == 'number') {
                condensed[i] = input[i] + input[i + 1]
            }
        }
        input.length--
        input = condensed
    }
    console.log(input[0])
}
