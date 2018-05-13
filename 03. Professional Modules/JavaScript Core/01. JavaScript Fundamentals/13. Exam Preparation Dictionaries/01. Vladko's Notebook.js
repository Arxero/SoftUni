function solution(input) {
    let result = {}
    let output = {}

    for (let row of input) {
        let splitter = row.split('|')
        let color = splitter[0]
        let property = splitter[1]
        let value = splitter[2]
        let opponents = []

        if (!result[color]) {
            result[color] = {
                wins: 0,
                losses: 0,
                opponents,
            }
        }

        switch (property) {
            case 'age':
                result[color][property] = value
                break;
            case 'name':
                result[color][property] = value
                break;
            case 'win':
                result[color].opponents.push(value)
                result[color].wins++
                break;
            case 'loss':
                result[color].opponents.push(value)
                result[color].losses++
                break;
        }
    }
    let sortedResult = Object.keys(result).sort()

    for (let row of sortedResult) {
        let rank = ((result[row].wins + 1) / (result[row].losses + 1)).toFixed(2)

        if (result[row].age && result[row].name) {
            output[row] = {
                'age': result[row].age,
                'name': result[row].name,
                'opponents': result[row].opponents.sort(),
                rank
            }
        }
    }
    return JSON.stringify(output)
}

// console.log(solution([
//     'purple|age|99',
//     'red|age|44',
//     'blue|win|pesho',
//     'blue|win|mariya',
//     'purple|loss|Kiko',
//     'purple|loss|Kiko',
//     'purple|loss|Kiko',
//     'purple|loss|Yana',
//     'purple|loss|Yana',
//     'purple|loss|Manov',
//     'purple|loss|Manov',
//     'red|name|gosho',
//     'blue|win|Vladko',
//     'purple|loss|Yana',
//     'purple|name|VladoKaramfilov',
//     'blue|age|21',
//     'blue|loss|Pesho'

// ]));

