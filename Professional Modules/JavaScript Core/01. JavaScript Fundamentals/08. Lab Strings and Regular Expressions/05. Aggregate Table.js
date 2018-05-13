function table(input) {
    let result = [];
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        let row = input[i].split(' ').filter(x => x != '' && x != '|');
        sum += Number(row[row.length - 1]);
        row.pop(row[row.length - 1]);
        result.push(row.join(' '));
    }
    console.log(result.join(', '));
    console.log(sum);
}
// table(
//     ['| Sofia           | 300',
//      '| Veliko Tarnovo  | 500',
//      '| Yambol          | 275']);