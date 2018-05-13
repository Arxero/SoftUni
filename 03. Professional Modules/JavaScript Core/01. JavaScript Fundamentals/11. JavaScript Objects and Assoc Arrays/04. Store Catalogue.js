function catalogue(input) {
    let results = new Map();

    for (let row of input) {
        let splitter = row.split(':').map(x => x.trim());
        let product = splitter[0];
        let price = Number(splitter[1]);
        results.set(product, price);
    }

    let sortedResults = Array.from(results.keys()).sort();
    let firstLetters = sortedResults.map(x => x[0]);
    let uniqueLetters = Array.from(new Set(firstLetters));

    for (let letter of uniqueLetters) {
        console.log(letter);
        for (let result of sortedResults) {
            if (result[0] == letter) {
                console.log(`  ${result}: ${results.get(result)}`);
            }
        }
    }
}
// catalogue([
//     'Appricot : 20.4',
//     'Fridge : 1500',
//     'TV : 1499',
//     'Deodorant : 10',
//     'Boiler : 300',
//     'Apple : 1.25',
//     'Anti-Bug Spray : 15',
//     'T-Shirt : 10'
// ]);