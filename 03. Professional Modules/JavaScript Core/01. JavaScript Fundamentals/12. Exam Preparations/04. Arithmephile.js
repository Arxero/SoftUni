function solve(input) {
    let result = [];
    let product = 1;

    for (let i = 0; i < input.length; i++) {
        let s = Number(input[i]);
        if (s >= 0 && s < 10) {
            for (let j = i; j < i + s; j++) {
                product *= Number(input[j + 1]);
            }
            result.push(product);
            product = 1;
        }
    }
    console.log(result.sort((a, b) => b - a)[0]);
}
// solve([
//     '10',
//     '20',
//     '2',
//     '30',
//     '44',
//     '3',
//     '56',
//     '20',
//     '24'
// ]);

// solve([
//     '100',
//     '200',
//     '2',
//     '3',
//     '2',
//     '3',
//     '2',
//     '1',
//     '1'
// ]);