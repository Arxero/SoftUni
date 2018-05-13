function equalNeighbors(matrix) {
    let counter = 0;
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            //checking each elemnt in array
            let a = matrix[row][col];
            let b = matrix[row][col + 1];
            if (a == b) {
                counter++;
            }

            //checking first elemnt of each array
            if (row < matrix.length - 1) {
                let c = matrix[row][col];
                let d = matrix[row + 1][col];
                if (c == d) {
                    counter++;
                }
            }
        }
    }
    console.log(counter);
}
//equalNeighbors(
//    [['2', '3', '4', '7', '0'],
//    ['4', '0', '5', '3', '4'],
//    ['2', '3', '5', '4', '2'],
//    ['9', '8', '7', '5', '4']]
//);

