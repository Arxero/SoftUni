function solution(input) {
    let allowedQuantity = +input[0]
    let daysLeft = +input[1]
    let totalPrice = 0
    let spirit = 0


    for (let i = 1; i <= daysLeft; i++) {
        if (i % 11 == 0) {
            allowedQuantity += 2
        }
        
        if (i % 2 == 0) {
            totalPrice += 2 * allowedQuantity
            spirit += 5
        }
        if (i % 3 == 0) {
            totalPrice += (5 + 3) * allowedQuantity
            spirit += 13
        }
        if (i % 5 == 0) {
            totalPrice += 15 * allowedQuantity
            spirit += 17
        }
        if (i % 3 == 0 && i % 5 == 0) {
            spirit += 30
        }

        if (i % 10 == 0) {
            spirit -= 20
            totalPrice += 5 + 3 + 15
        }

        if (i == daysLeft && i % 10 == 0) {
            spirit -= 30
        }
    }

    console.log('Total cost: ' + totalPrice)
    console.log('Total spirit: ' + spirit)
}
solution(['3', '20'])