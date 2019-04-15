function solution(input) {
    input = input[0].split(', ')
    let result = {}

    for (let row of input) {
        if (row.includes('-')) {
            let [game, price] = row.split('-')

            if (!result.hasOwnProperty(game)) {
                result[game] = +price
            }
        } else {
            let [game, dlc] = row.split(':')

            if (result.hasOwnProperty(game)) {
                let oldPrice = result[game]
                oldPrice = oldPrice + (oldPrice * 20 / 100)
                delete result[game]
                let gameWithDlc = game + ' - ' + dlc
                result[gameWithDlc] = oldPrice
            }
        }
    }

    Object.entries(result).forEach(x => {
        if (!x[0].includes('-')) {
            result[x[0]] = x[1] - (x[1] * 20 / 100)
        } else {
            result[x[0]] = x[1] - (x[1] * 50 / 100)
        }
        result[x[0]] = result[x[0]].toFixed(2)
    })

    Object.entries(result).filter(x => x[0].includes('-'))
        .sort((a, b) => +a[1] - +b[1])
        .forEach(x => console.log(x[0] + ' - ' + x[1]))

    Object.entries(result).filter(x => !x[0].includes('-'))
        .sort((a, b) => +b[1] - +a[1])
        .forEach(x => console.log(x[0] + ' - ' + x[1]))
}
solution(['WitHer 3-50, FullLife 3-60, WitHer 3:Blood and Beer, Cyberfunk 2077-120, League of Leg Ends-10, League of Leg Ends:DoaT'])