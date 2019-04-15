function solution(startingYield) {
    let spice = 0
    let daysMined = 0

    while (startingYield >= 100) {
        spice += startingYield - 26
        startingYield -= 10
        daysMined++
    }

    console.log(daysMined)
    console.log(spice >= 26 ? spice - 26 : spice)
}
