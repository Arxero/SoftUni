function solution(input) {
    input = input.split(' ').map(x => x.toLowerCase())
    let result = new Map

    for (let row of input) {
        if (!result.has(row)) {
            result.set(row, 1)
        } else {
            let oldCount = result.get(row)
            result.set(row, oldCount + 1)
        }
    }

    let str = ''
    let oddOccurrencesFiltered = [...result].filter(x => x[1] % 2 != 0).forEach(x => {
        str += x[0] + ' '
    })

    console.log(str.trim())
}
solution('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')