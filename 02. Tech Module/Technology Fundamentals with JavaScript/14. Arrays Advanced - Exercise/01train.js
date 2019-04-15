function solution(input) {
    let wagons = input.shift().split(' ').map(x => +x)
    let maxCapacity = +input.shift()

    for (let row of input) {
        row = row.split(' ')
        if (row.length == 2) {
            let wagon = +row[1]
            wagons.push(wagon)
        } else {
            let passengers = +row[0]
            for (let i = 0; i < wagons.length; i++) {
                if (wagons[i] + passengers <= maxCapacity) {
                    wagons.splice(i, 1, passengers + wagons[i])
                    break;
                }
            }
        }
    }

    console.log(wagons.join(' '))
}
