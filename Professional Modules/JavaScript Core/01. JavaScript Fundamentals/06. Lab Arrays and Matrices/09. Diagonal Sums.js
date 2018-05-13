function diagonalSum(matrix) {
    let main = 0;
    let secondary = 0;
    let a = 0;
    let b = 0;
    for (let row = 0; row < matrix.length; row++) {
        main += matrix[row][a++];
        secondary += matrix[row][(matrix[row].length - 1) - b++];
    }
    console.log(`${main} ${secondary}`);
}
//diagonalSum([[20, 40], [10, 60]]);
//diagonalSum([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);