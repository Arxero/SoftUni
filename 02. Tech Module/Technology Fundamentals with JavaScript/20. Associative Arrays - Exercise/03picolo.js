function solution(input) {
    let result = []

    for (let row of input) {
        let [direction, number] = row.split(', ')
        if (direction == 'IN') {
            if (!result.includes(number)) {
                result.push(number)
            }
        } else {
            if (result.includes(number)) {
                let indexOfNumber = result.indexOf(number)
                result.splice(indexOfNumber, 1)
            }
        }
    }

    result = result.sort((a, b) => a.localeCompare(b) - b.localeCompare(a))

    if (result.length) {
        console.log(result.join('\n'))
        return
    }
    console.log('Parking Lot is Empty')
}
