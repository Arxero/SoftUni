function solution(input) {
    let water = +input.pop()
    let fireLevel = input[0].split('#')
    let cells = []
    let effort = 0
    let totalFire = 0

    for (let i = 0; i < fireLevel.length; i++) {
        let splitter = fireLevel[i].split(' = ')
        let fireType = splitter[0]
        let fireAmount = +splitter[1]

        if (fireType == 'High' && (fireAmount >= 81 && fireAmount <= 125) && water >= fireAmount) {
            water -= fireAmount
            cells.push(fireAmount)
            effort += fireAmount * 25 / 100
            totalFire += fireAmount
        } else if (fireType == 'Medium' && (fireAmount >= 51 && fireAmount <= 80) && water >= fireAmount) {
            water -= fireAmount
            cells.push(fireAmount)
            effort += fireAmount * 25 / 100
            totalFire += fireAmount
        } else if (fireType == 'Low' && (fireAmount >= 1 && fireAmount <= 50) && water >= fireAmount) {
            water -= fireAmount
            cells.push(fireAmount)
            effort += fireAmount * 25 / 100
            totalFire += fireAmount
        }
    }

    console.log('Cells:')
    for (let cell of cells) {
        console.log(' - ' + cell)
    }

    console.log('Effort: ' + effort.toFixed(2))
    console.log('Total Fire: ' + totalFire)
}
// solution([
//     'High = 89#Meduim = 53#Low = 28#Medium = 77#Low = 23',
//     '1250'
// ])

solution([
    'High = 150#Low = 55#Medium = 86#Low = 40#High = 110#Medium = 77',
    '220'
])