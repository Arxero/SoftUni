function solution(input, bombInfo) {
    let bomb = bombInfo[0]
    let power = bombInfo[1]

    while (input.indexOf(bomb) >= 0) {
        let bombIndex = input.indexOf(bomb)
        let start = bombIndex - power
        let deleteCount = (power * 2) + 1
        if (start < 0) {
            start = 0
            deleteCount--
        }
        input.splice(start, deleteCount)
    }

    console.log(input.reduce((a, b,) => a + b, 0))
}
