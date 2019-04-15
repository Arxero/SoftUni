function solution(input) {
    let roads = {}

    for (let row of input) {
        if (row == 'END') break
        let [command, road, racer, nextRoad] = row.split('->')

        if (command == 'Add') {
            if (!roads.hasOwnProperty(road)) {
                let racers = []
                racers.push(racer)
                roads[road] = racers
            } else {
                let currentRacers = roads[road]
                currentRacers.push(racer)
                roads[road] = currentRacers
            }
        } else if (command == 'Move') {
            let currentRacersMove = roads[road]

            if (currentRacersMove.includes(racer)) {
                let indexOfRacer = currentRacersMove.indexOf(racer)
                let racerToMove = currentRacersMove[indexOfRacer]
                currentRacersMove.splice(indexOfRacer, 1)
                let nextRoadRacers = roads[nextRoad]
                nextRoadRacers.push(racerToMove)
                roads[nextRoad] = nextRoadRacers
            }
        } else {
            if (roads.hasOwnProperty(road)) {
                delete roads[road]
            }
        } 
    }

    let sorted = Object.entries(roads).sort((a, b) => {
        if (a[1].length < b[1].length) {
            return b[1].length - a[1].length
        } else if (a[1].length == b[1].length) {
            return a[0].localeCompare(b[0])
        }
    })

    console.log('Practice sessions:')
    sorted.forEach(x => {
        console.log(x[0])
        x[1].forEach(x => console.log('++' + x))
    })
}
solution([
    'Add->Glencrutchery Road->Giacomo Agostini',
    'Add->Braddan->Geoff Duke',
    'Add->Peel road->Mike Hailwood',
    'Add->Glencrutchery Road->Guy Martin',
    'Move->Glencrutchery Road->Giacomo Agostini->Peel road',
    'Close->Braddan',
    'END'
])