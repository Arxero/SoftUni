function mine(input) {
    let bitcoinsCount = 0;
    let minedBitcoins = 0;
    let dayOfTheFirstPurchasedBitcoin = 0;
    let isItBought = false;

    for (let i = 1; i <= input.length; i++) {
        let gold = Number(input[i - 1]);
        if (i % 3 == 0 ) {
            gold = gold - (gold * 0.3);
        }

        minedBitcoins += gold * 67.51;
        if (minedBitcoins >= 11949.16) {
            while (minedBitcoins >= 11949.16) {
                minedBitcoins -= 11949.16; 
                bitcoinsCount++;
            }
            
            if (!isItBought) {
                dayOfTheFirstPurchasedBitcoin = i;
                isItBought = true;
            }
        }
    }
    console.log(`Bought bitcoins: ${bitcoinsCount}`);
    if (isItBought) {
        console.log(`Day of the first purchased bitcoin: ${dayOfTheFirstPurchasedBitcoin}`);
    }
    console.log(`Left money: ${minedBitcoins.toFixed(2)} lv.`);
}
//mine(['100', '200', '300']);
//mine(['50', '100']);
//mine(['3124.15', '504.212', '2511.124']);