function enginering(input) {
    let results = new Map();

    for (let row of input) {
        let splitter = row.split(' | ');
        let brand = splitter[0];
        let model = splitter[1];
        let quantity = Number(splitter[2]);

        if (!results.has(brand)) {
            results.set(brand, new Map());
        }
        if (!results.get(brand).has(model)) {
            results.get(brand).set(model, 0);
        }
        let oldQuantity = results.get(brand).get(model);
        results.get(brand).set(model, oldQuantity + quantity);
    }
    for (let result of results.keys()) {
        console.log(result);
        for (let model of results.get(result)) {
            console.log(`###${model[0]} -> ${model[1]}`);
        }
    }
}
// enginering([
//     'Audi | Q7 | 1000',
//     'Audi | Q6 | 100',
//     'BMW | X5 | 1000',
//     'BMW | X6 | 100',
//     'Citroen | C4 | 123',
//     'Volga | GAZ-24 | 1000000',
//     'Lada | Niva | 1000000',
//     'Lada | Jigula | 1000000',
//     'Citroen | C4 | 22',
//     'Citroen | C5 | 10'
// ]);