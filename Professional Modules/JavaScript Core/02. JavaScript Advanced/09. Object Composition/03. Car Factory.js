function solution(input) {
    let result = {}
    result['model'] = input.model

    if (input.power <= 90) {
        result['engine'] = { power: 90, volume: 1800 }
    } else if (input.power > 90 && input.power <= 120) {
        result['engine'] = { power: 120, volume: 2400 }
    } else if (input.power > 120 && input.power <= 200) {
        result['engine'] = { power: 200, volume: 3500 }
    }

    if (input.carriage == 'hatchback') {
        result['carriage'] = { type: 'hatchback', color: input.color }
    } else {
        result['carriage'] = { type: 'coupe', color: input.color }
    }

    if (input.wheelsize % 2 == 0) {
        input.wheelsize -= 1
    }
    let wheels = []
    for (let i = 0; i < 4; i++) {
        wheels.push(input.wheelsize)
    }
    result['wheels'] = wheels
    return result

}

// solution(
//     {
//         model: 'VW Golf II',
//         power: 90,
//         color: 'blue',
//         carriage: 'hatchback',
//         wheelsize: 14
//     }
// )

// solution(
//     {
//         model: 'Opel Vectra',
//         power: 110,
//         color: 'grey',
//         carriage: 'coupe',
//         wheelsize: 17
//     }
// )