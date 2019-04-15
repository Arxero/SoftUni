function solution(lostFightsCount, helmetPrice, swordPrice, shieldPrice, armorPrice) {
    let expenses = 0
    let brokenShiledCount = 0

    for (let i = 1; i <= lostFightsCount; i++) {
        if (i % 2 == 0) {
            expenses += helmetPrice
        }
        if (i % 3 == 0) {
            expenses += swordPrice
        }
        if (i % 2 == 0 && i % 3 == 0) {
            brokenShiledCount++
            expenses += shieldPrice
            if (brokenShiledCount % 2 == 0) {
                expenses += armorPrice
            }
        }
    }
    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`)
}
//solution(7, 2, 3, 4, 5)
solution(23, 12.5, 21.5, 40, 200)