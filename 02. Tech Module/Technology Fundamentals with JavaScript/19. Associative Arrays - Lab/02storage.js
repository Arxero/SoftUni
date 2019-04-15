function solution(input) {
    let result = new Map

    for (let row of input) {
        let [item, quantity] = row.split(' ')

        if (result.has(item)) {
            let currentQuantity = result.get(item)
            let newQuantity  = currentQuantity += +quantity
            result.set(item, newQuantity)
        } else {
            result.set(item, +quantity)
        }
    }

    for (const [key, value] of result) {
        console.log(key + ' -> ' + value)
    }
}

