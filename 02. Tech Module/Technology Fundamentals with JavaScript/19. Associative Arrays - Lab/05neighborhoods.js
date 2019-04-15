function solution(input) {
    let neighborhoods = input.shift().split(', ')
    let result = new Map

    for (let row of neighborhoods) {
        if (!result.has(row)) {
            result.set(row, [])
        }
    }

    for (let row of input) {
        let [neighborhood, person] = row.split(' - ')
        
        if (result.has(neighborhood)) {
            let neighbors = result.get(neighborhood)
            neighbors.push(person)
            result.set(neighborhood, neighbors)
        }
    }

    let sortedByInhabitantsCount = [...result].sort((a, b) => b[1].length - a[1].length)

    for (let [key, value] of sortedByInhabitantsCount) {
        console.log(key + ': ' + value.length)
        for (let person of value) {
            console.log('--' + person)
        }
    }
}
