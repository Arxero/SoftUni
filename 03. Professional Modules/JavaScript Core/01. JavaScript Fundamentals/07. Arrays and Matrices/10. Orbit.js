function orbit(input) {
    let size = input[0];
    let x = input[2];
    let y = input[3];
    let matrix = [];

    for (let i = 0; i < size; i++) {
        matrix.push([]);
    }
    
    for (let row = 0; row < size; row++) {
        for (let col = 0; col < size; col++) {
            matrix[row][col] = Math.max(Math.abs(row - x), Math.abs(col - y)) + 1;
        }
    }
    console.log(matrix.map(x => x.join(' ')).join('\n'));

}
//orbit([4, 4, 0, 0]);
//orbit([5, 5, 0, 0]);