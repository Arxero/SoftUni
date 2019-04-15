function solution(input) {
    let oneBitcoinInLv = 11949.16
    let oneGramGoldInLv = 67.51
    let boughtBitcoins = 0
    let dayOfTheFirstPurchasedBitcoin = 0
    let moneyEarned = 0

    for (let i = 0; i < input.length; i++) {
        let gold = input[i]

        //check if it is the 3th day in a row in order to steal 30% gold
        if ((i + 1) % 3 == 0) {
            gold = gold - (gold / 100 * 30)
        }
        moneyEarned += gold * oneGramGoldInLv

        //check if we have enough money to buy bitcoin this day
        if (moneyEarned >= oneBitcoinInLv) {
            while (moneyEarned > oneBitcoinInLv) {
                moneyEarned -= oneBitcoinInLv
                boughtBitcoins++
            }

            //check if day of the first purchased bitcoin has been altered
            if (dayOfTheFirstPurchasedBitcoin == 0) {
                dayOfTheFirstPurchasedBitcoin = i + 1
            }
        }
    }

    console.log('Bought bitcoins: ' + boughtBitcoins)
    if (boughtBitcoins) {
        console.log('Day of the first purchased bitcoin: ' + dayOfTheFirstPurchasedBitcoin)
    }
    console.log('Left money: ' + moneyEarned.toFixed(2) + ' lv.')
}
