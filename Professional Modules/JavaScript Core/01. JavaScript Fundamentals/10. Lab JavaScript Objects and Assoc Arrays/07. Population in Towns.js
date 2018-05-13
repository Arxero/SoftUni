function population(input) {
    let results = new Map();

    for (const row of input) {
        let town = row.split(' <-> ') [0];
        let population = Number(row.split(' <-> ') [1]);

        if (!results.has(town)) {
            results.set(town, population);
        }
        else {
            results.set(town, results.get(town) + population);
        }
    }

    for (const result of results) {
        console.log(`${result[0]} : ${result[1]}`);
    }
}
// population(['Sofia <-> 1200000','Montana <-> 20000', 'New York <-> 10000000', 'Washington <-> 2345000', 'Las Vegas <-> 1000000']);