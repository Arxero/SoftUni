function solution(distance, passengers, price) {
    let neededFuel = distance / 100 * 7
    neededFuel += passengers * .1
    console.log(`Needed money for that trip is ${neededFuel * price}lv.`)
}
