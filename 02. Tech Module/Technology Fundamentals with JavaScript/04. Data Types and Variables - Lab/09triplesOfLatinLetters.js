function solution(input) {
    for (let i = 0; i < input; i++) {
        for (let k = 0; k < input; k++) {
            for (let l = 0; l < input; l++) {
                console.log(`${String.fromCharCode(97 + i)}${String.fromCharCode(97 + k)}${String.fromCharCode(97 + l)}`)
            }
        }
    }
}
