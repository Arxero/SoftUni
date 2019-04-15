function solution(input) {
    let result = {}

    for (let i = 0; i < input.length; i++) {
        let inputLine = input[i].split(' : ')
        let productName = inputLine[0]
        let productPrice = inputLine[1]
        result[productName] = +productPrice
    }

    let ordered = {}
    Object.keys(result).sort(sortAphabetically).forEach(key => ordered[key] = result[key])

    function sortAphabetically(a, b) {
        return a.localeCompare(b)
    }

    let firstLettersUnique = []
    for (const key in ordered) {
        firstLettersUnique.push(key.slice(0, 1))
    }
    firstLettersUnique = firstLettersUnique.filter((v, i, a) => a.indexOf(v) == i)

    for (let i = 0; i < firstLettersUnique.length; i++) {
        console.log(firstLettersUnique[i])

        for (const key in ordered) {
            if (key.startsWith(firstLettersUnique[i])) {
                console.log( '  ' + key + ': ' + ordered[key])
            }
        }
    }
}
