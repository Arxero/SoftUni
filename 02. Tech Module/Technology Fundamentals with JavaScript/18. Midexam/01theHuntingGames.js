function solution(input) {
    let days = +input.shift()
    let players = +input.shift()
    let energy = +input.shift()
    let water = +input.shift()
    let food = +input.shift()
    input = input.filter(x => x != '')
    let totalWater = days * players * water
    let totalFood = days * players * food


    for (let i = 1; i <= days; i++) {
        let dailyEnergyLoss = +input[i - 1]
        energy -= dailyEnergyLoss

        if (energy <= 0) {
            console.log(`You will run out of energy. You will be left with ${totalFood.toFixed(2)} food and ${totalWater.toFixed(2)} water.`)
            return
        }
        if (i % 2 == 0) {
            energy += energy * 5 / 100
            totalWater -= totalWater * 30 / 100
        }
        if (i % 3 == 0) {
            totalFood = totalFood - (totalFood / players)
            energy += energy * 10 / 100
        }
    }

    console.log(`You are ready for the quest. You will be left with - ${energy.toFixed(2)} energy!`)
}
