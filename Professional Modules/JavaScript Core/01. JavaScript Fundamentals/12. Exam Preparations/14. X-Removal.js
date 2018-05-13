function xRemove(input) {
    let result = input.map(x => Array.from(x));
    let matrix = input.map(x => x.toLowerCase());

    for (let row = 0; row < matrix.length - 2; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            let position = matrix[row][col];
            if (position != undefined && matrix[row][col + 2] != undefined && matrix[row + 1][col + 1] != undefined && matrix[row + 2][col] != undefined && matrix[row + 2][col + 2] != undefined) {
                if (position == matrix[row][col + 2] && position == matrix[row + 1][col + 1] && position == matrix[row + 2][col] && position == matrix[row + 2][col + 2]) {
                    result[row][col] = result[row][col + 2] = result[row + 1][col + 1] = result[row + 2][col] = result[row + 2][col + 2] = ' ';
                }
            }
        }
    }
    console.log([...result].map(x => x.filter(x => x != ' ').join('')).join('\n'));
}
// xRemove([
//     'abnbjs',
//     'xoBab',
//     'Abmbh',
//     'aabab',
//     'ababvvvv'
// ]);