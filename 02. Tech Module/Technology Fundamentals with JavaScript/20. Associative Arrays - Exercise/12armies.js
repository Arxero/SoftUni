function solution(input) {
    let result = {}

    for (let row of input) {
        let leader = ''

        if (row.includes('arrives')) {
            row = row.split(' ')
            leader = row.filter(x => x != 'arrives').join(' ')
            result[leader] = {}
            
        } else if (!row.includes('arrives') && !row.includes('defeated')){
            row = row.split(': ')
            if (row.length  == 2) { //if we have leader army name and army count
                leader = row[0]
                if (result.hasOwnProperty(leader)) {
                    let [armyName, armyCount] = row[1].split(', ')
                    
                    if (Object.entries(result[leader]).length == 0) { // check if the leader has any army
                        let army = {}
                        army[armyName] = +armyCount
                        result[leader] = army
                    } else {
                        let oldArmy = result[leader]
                        oldArmy[armyName] = +armyCount
                        result[leader] = oldArmy
                    }
                    
                }
            } else { // when we have only army name and army count
                let [armyName, armyNewCount] = row[0].split(' + ')
                Object.entries(result).forEach(x => {
                    leader = x[0]
                    if (result[leader].hasOwnProperty(armyName)) { //if the army exist somewhere
                        result[leader][armyName] += +armyNewCount
                    }
                })
            }
        } else {
            leader = row.replace(' defeated', '')
            delete result[leader]
        }
    }

    let sortedByTotalArmy = Object.entries(result).sort((a, b) => {
        let totalArmyCountA = 0
        let totalArmyCountB = 0
        Object.entries(a[1]).forEach(x => totalArmyCountA += x[1])
        Object.entries(b[1]).forEach(x => totalArmyCountB += x[1])
        
        if (totalArmyCountA < totalArmyCountB) {
            return 1
        } else if (totalArmyCountA > totalArmyCountB) {
            return -1
        }
    })

    sortedByTotalArmy.forEach(x => {
        let totalArmyCount = 0
        x[1] = Object.entries(x[1]).sort((a, b) => b[1] - a[1])
        x[1].forEach(x => totalArmyCount += x[1])
        console.log(x[0] + ': ' + totalArmyCount)
        x[1].forEach(x => console.log('>>> ' + x[0] + ' - ' + x[1]))
    })
}
