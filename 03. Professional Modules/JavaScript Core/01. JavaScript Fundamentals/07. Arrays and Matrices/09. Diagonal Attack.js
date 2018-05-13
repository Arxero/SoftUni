function diagonalAttack(input) {
    let matrix = [];
    for (let i = 0; i < input.length; i++) {
        let splittedArr = input[i].split(" " ).map(Number);
        matrix.push(splittedArr);
    }

    let sumMain = 0;
    let row = 0;
    let sumSecondary = 0;
    let col = matrix.length - 1;

    for (let i = 0; i < matrix.length; i++) {
        sumMain += matrix[row][i];
        sumSecondary += matrix[row++][col--];
    }
    row = 0;
    col = matrix.length - 1;
    let n = 0
    if (sumMain == sumSecondary) {
        for (let j = 0; j < matrix.length; j++) {
            for (let k = 0; k < matrix.length; k++) {
                if (row == j && n != k && row == j && col != k) {
                    matrix[j][k] = sumMain;
                }
            }
            n++;
            col--;
            row++;
        }
    }

    console.log(matrix.map(x => x.join(' ')).join('\n'));
}
// diagonalAttack(['5 3 12 3 1',
//     '11 4 23 2 5',
//     '101 12 3 21 10',
//     '1 4 5 2 2',
//     '5 22 33 11 1']);
//diagonalAttack(['1 1 1', '1 1 1', '1 1 0'])