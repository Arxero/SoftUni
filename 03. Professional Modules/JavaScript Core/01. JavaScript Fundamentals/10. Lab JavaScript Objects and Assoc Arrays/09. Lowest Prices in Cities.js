function lowestPrice(input) {
    let results = new Map();

    for (const row of input) {
        let town = row.split(' | ') [0];
        let product = row.split(' | ') [1];
        let price = Number(row.split(' | ') [2]);

        if (!results.has(product)) {
            results.set(product, new Map());
        }
        results.get(product).set(town, price);
    }

    for (let [product, inside] of results) {
        let lowestPrice = Number.POSITIVE_INFINITY;
        let townLowestPrice = '';
        for (let [town, price] of inside) {
            if (price < lowestPrice) {
                lowestPrice = price;
                townLowestPrice = town;
            }
        }
        console.log(`${product} -> ${lowestPrice} (${townLowestPrice})`);
    }
}
// lowestPrice([
//     'Sample Town | Sample Product | 1000',
//     'Sample Town | Orange | 2',
//     'Sample Town | Peach | 1',
//     'Sofia | Orange | 3',
//     'Sofia | Peach | 2',
//     'New York | Sample Product | 1000.1',
//     'New York | Burger | 10'
// ]);