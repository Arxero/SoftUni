function solution(input) {
    let currentStock = input[0]
    let orderedStock = input[1]
    let result = {}

    for (let i = 0; i < currentStock.length; i++) {
        if (i % 2 == 0) {
            result[currentStock[i]] = +currentStock[i + 1]
        }
    }

    for (let i = 0; i < orderedStock.length; i++) {
        if (i % 2 == 0) {
            if (result.hasOwnProperty(orderedStock[i])) {
                let key = orderedStock[i]
                let value = +orderedStock[i + 1]
                result[key] += value
                
            } else {
                result[orderedStock[i]] = +orderedStock[i + 1]
            }

        }
    }

    console.log(result)
}
