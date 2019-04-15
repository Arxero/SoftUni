function solution(input) {
    input = input[0].split('|')
    let health = 100
    let coins = 0

    for (let i = 0; i < input.length; i++) {
        let [item, number] = input[i].split(' ')
        number = +number

        if (item == 'potion') {
            if (health + number <= 100) {
                health += number
            } else if (health + number > 100) {
                if (health == 100) {
                    number = 0
                } else {
                    number = 100 - health
                    health = 100
                }
            }
            console.log(`You healed for ${number} hp.`)
            console.log(`Current health: ${health} hp.`)
        } else if (item == 'chest') {
            coins += number
            console.log(`You found ${number} coins.`)
        } else {
            health -= number
            if (health > 0) {
                console.log(`You slayed ${item}.`)
            } else {
                console.log(`You died! Killed by ${item}.`)
                console.log(`Best room: ${i + 1}`)
                return
            }
        }
    }

    console.log(`You've made it!`)
    console.log('Coins: ' + coins)
    console.log('Health: ' + health)
}
