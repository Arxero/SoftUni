function solution(input) {
    let washAmount = 0
    for (let command of input) {
        switch (command) {
            case 'soap':
                washAmount += 10
                break;
            case 'water':
                washAmount += (20 / 100 * washAmount)
                break;
            case 'vacuum cleaner':
                washAmount += (25 / 100 * washAmount)
                break;
            case 'mud':
                washAmount -= (10 / 100 * washAmount)
                break;
        }
    }

    console.log(`The car is ${washAmount.toFixed(2)}% clean. `)
}
