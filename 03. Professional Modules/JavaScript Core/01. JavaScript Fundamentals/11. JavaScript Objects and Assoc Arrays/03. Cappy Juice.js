function cappy(input) {
    let results = {};
    let bottles = {};

    for (let row of input) {
        let splitter = row.split(' => ');
        let juice = splitter[0];
        let quantity = Number(splitter[1]);

        if (!results.hasOwnProperty(juice)) {
            results[juice] = 0;
        }
        results[juice] += quantity

        if (results[juice] >= 1000) {
            bottles[juice] = Math.floor(results[juice] / 1000);
        }
    }
    for (let bottle of Object.keys(bottles)) {
        console.log(`${bottle} => ${bottles[bottle]}`);
    }
}
// cappy([
//     'Kiwi => 234',
//     'Pear => 2345',
//     'Watermelon => 3456',
//     'Kiwi => 4567',
//     'Pear => 5678',
//     'Watermelon => 6789'
// ]);
// cappy([
//     'Orange => 2000',
//     'Peach => 1432',
//     'Banana => 450',
//     'Peach => 600',
//     'Strawberry => 549'
// ]);