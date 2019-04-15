function solution(input) {
    let result = {}

    for (let row of input) {
        let [country, town, price] = row.split(' > ')

        if (!result.hasOwnProperty(country)) { //we don't have the country yet
            let townObj = {}
            townObj[town] = +price
            result[country] = townObj // we save the country
        } else { //we have the country
            let currentTown = result[country]

            if (!currentTown.hasOwnProperty(town)) { //we dont have the town
                currentTown[town] = +price
                result[country] = currentTown // we save the new town
            } else if (currentTown.hasOwnProperty(town)) { // we have the town
                let currentTownPrice = result[country][town]
                if (price < currentTownPrice) { // if the new price is lower
                    result[country][town] = price // we save the cheaper one
                }

            }
        }
    }

    let sorted = Object.entries(result).sort((a, b) => a[0].localeCompare(b[0]))
    let sortedByPrice = {}

    sorted.forEach(x => {
        let countryName = x[0]
        let townToSort = Object.entries(x[1]).sort((a, b) => a[1] - b[1])
        sortedByPrice[countryName] = townToSort

    })

    for (let countries of Object.entries(sortedByPrice)) {
        let str = countries[0] + ' -> '
        let towns = countries[1]
        for (let town of towns) {
            str += `${town[0]} -> ${town[1]} `
        }
        console.log(str.trim())
    }
}
