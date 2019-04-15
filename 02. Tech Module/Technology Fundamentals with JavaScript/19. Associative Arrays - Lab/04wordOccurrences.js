function solution(input) {
    let result = new Map

    for (let row of input) {
        if (!result.has(row)) {
            result.set(row, 1)
        } else {
            let oldCount = result.get(row)
            oldCount++
            result.set(row, oldCount)
        }
    }

    let sorted = [...result].sort((a, b) => b[1] - a[1])

    for (let [key, value] of sorted) {
        console.log(key + ' -> ' + value + ' times')
    }
}
