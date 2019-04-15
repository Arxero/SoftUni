function solution(input) {
    let words = input.shift().split(' ')
    let result = new Map

    words.forEach(x => result.set(x, 0))

    for (let row of input) {
        if (result.has(row)) {
            let oldCount = result.get(row)
            oldCount++
            result.set(row, oldCount)
        }
    }

    [...result].sort((a, b) => b[1] - a[1]).forEach(x => console.log(x[0] + ' - ' + x[1]))
}
