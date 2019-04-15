function solution(input) {
    let energy = 100
    let coins = 100
    input = input[0].split('|')

    for (let i = 0; i < input.length; i++) {
        let splitter = input[i].split('-')
        let event = splitter[0]
        let number = +splitter[1]

        if (event == 'rest' && energy + number <= 100) {
            energy += number
            console.log(`You gained ${number} energy.`)
            console.log(`Current energy: ${energy}.`)
        } else if (event == 'rest' && energy + number > 100) {
            let gainedEnergy = 100 - energy
            energy += gainedEnergy
            console.log(`You gained ${gainedEnergy} energy.`)
            console.log(`Current energy: ${energy}.`)
        }

        if (event == 'order' && energy - 30 >= 0) {
            coins += number
            energy -= 30
            console.log(`You earned ${number} coins.`)
        } else if (event == 'order' && energy - 30 < 0) {
            energy += 50
            console.log('You had to rest!')
        }

        if (event != 'rest' && event != 'order' && coins - number > 0) {
            coins -= number
            console.log(`You bought ${event}.`)
        } else if (event != 'rest' && event != 'order' && coins - number <= 0) {
            console.log(`Closed! Cannot afford ${event}.`)
            return
        }
    }

    console.log('Day completed!')
    console.log('Coins: ' + coins)
    console.log('Energy: ' + energy)
}
