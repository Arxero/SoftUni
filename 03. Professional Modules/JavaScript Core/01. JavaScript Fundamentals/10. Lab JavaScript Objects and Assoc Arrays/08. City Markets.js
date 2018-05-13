function markets(input) {
    let results = new Map();

    for (const row of input) {
        let [town, product, sales, unit] = row.split(/ -> | : /);
        let income = sales * unit;

        // is town exists
        if (!results.has(town)) {
            results.set(town, new Map());
            results.get(town).set(product, income);
        }
        else { // yes
            //do we have product in town?
            if (!results.get(town).has(product)) {
                results.get(town).set(product, income);
            }
            else{
                let previousIncome = results.get(town).get(product);
                results.get(town).set(product, previousIncome + income);
            }
        }
    }

    for (let [town, products] of results) {
        console.log(`Town - ${town}`);
        for (const [product, income] of products) {
            console.log(`$$$${product} : ${income}`);
        }
        
    }
}
markets([
    'Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3'
])