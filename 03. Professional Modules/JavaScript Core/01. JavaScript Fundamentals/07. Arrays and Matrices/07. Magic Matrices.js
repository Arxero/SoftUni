function getMagic(matrix) {
    let sum = matrix[0].reduce((a, b) => a + b);
    let magic = true;

    for (let row = 0; row < matrix.length; row++) {
        let rowSum = 0;
        for (let col = 0; col < matrix.length; col++) {
            rowSum += matrix[row][col];
        }
        if (rowSum != sum) {
            magic = false;
        }
    }
    console.log(magic);
}
//getMagic(
//    [[4, 5, 6],
//   [6, 5, 4],
//   [5, 5, 5]]
//);