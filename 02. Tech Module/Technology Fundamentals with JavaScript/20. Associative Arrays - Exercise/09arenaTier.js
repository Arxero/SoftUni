function solution(input) {
    input.pop()
    let result = {}
    let gladiators = input.filter(x => !x.includes('vs'))

    for (let row of gladiators) {
        let [gladiator, technique, skill] = row.split(' -> ')

        if (!result.hasOwnProperty(gladiator)) {
            let techniqueAndSkill = {}
            techniqueAndSkill[technique] = +skill
            result[gladiator] = techniqueAndSkill
        } else {
            let currentTechniques = result[gladiator]

            if (!currentTechniques.hasOwnProperty(technique)) {
                currentTechniques[technique] = +skill
                result[gladiator] = currentTechniques
            } else {
                let currentSkill = result[gladiator][technique]
                if (+skill > currentSkill) {
                    result[gladiator][technique] = +skill
                }
            }
        }
    }

    let fights = input.filter(x => x.includes('vs'))

    if (fights.length > 0) {
        for (let row of fights) {
            let [gladiator, gladiator2] = row.split(' vs ')

            if (result.hasOwnProperty(gladiator) && result.hasOwnProperty(gladiator2)) {
                let gladiatorTechniques = Object.keys(result[gladiator])
                let gladiator2Techniques = Object.keys(result[gladiator2])

                let filteredGladiatorTechchniques = Object.entries(result[gladiator]).filter(x => gladiator2Techniques.includes(x[0])).sort((a, b) => a[0].localeCompare(b[0]))
                let filteredGladiator2Techchniques = Object.entries(result[gladiator2]).filter(x => gladiatorTechniques.includes(x[0])).sort((a, b) => a[0].localeCompare(b[0]))
                
                if (filteredGladiatorTechchniques.length > 0 && filteredGladiator2Techchniques.length > 0) {
                    for (let i = 0; i < filteredGladiatorTechchniques.length; i++) {
                        if (filteredGladiatorTechchniques[i][1] > filteredGladiator2Techchniques[i][1]) {
                            delete result[gladiator2]
                            break
                        } else if (filteredGladiatorTechchniques[i][1] < filteredGladiator2Techchniques[i][1]) {
                            delete result[gladiator]
                            break
                        }
                    }
                }
            }
        }
    }
    
    let sorted = Object.entries(result).sort((a, b) => {
        let aSum = 0
        let bSum = 0
        Object.entries(a[1]).map(x => aSum += x[1])
        Object.entries(b[1]).map(x => bSum += x[1])
        if (aSum < bSum) {
            return 1
        } else if (aSum == bSum) {
            return a[0].localeCompare(b[0])
        }
    })

    for (let gladiator of sorted) {
        let totalSkill = 0
        Object.entries(gladiator[1]).forEach(x => totalSkill += x[1])
        console.log(`${gladiator[0]}: ${totalSkill} skill`)

        let sortedTechniques = Object.entries(gladiator[1]).sort((a, b) =>{
            if (a[1] < b[1]) {
                return 1
            } else if (a[1] == b[1]) {
                return a[0].localeCompare(b[0])
            }
        })
        
        for (let technique of sortedTechniques) {
            console.log(`- ${technique[0]} <!> ${technique[1]}`)
        }
    }
}
// solution([
//     'Aeter -> BattleCry -> 450',
//     'Alex -> PowerPunch -> 300',
//     'Stefan -> Duck -> 200',
//     'Stefan -> Tiger -> 250',
//     'Ave Cesar'
// ])
// solution([
//     'Pesho -> BattleCry -> 400',
//     'Gosho -> PowerPunch -> 300',
//     'Stamat -> Duck -> 200',
//     'Stamat -> Tiger -> 250',
//     'Ave Cesar'
// ])
// solution([
//     'Pesho -> Duck -> 400',
//     'Julius -> Shield -> 150',
//     'Gladius -> Heal -> 200',
//     'Gladius -> Support -> 250',
//     'Gladius -> Shield -> 250',
//     'Pesho vs Gladius',
//     'Gladius vs Julius',
//     'Gladius vs Gosho',
//     'Ave Cesar'
// ])
solution([
    'Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Peter vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Maximilian',
    'Ave Cesar'
])