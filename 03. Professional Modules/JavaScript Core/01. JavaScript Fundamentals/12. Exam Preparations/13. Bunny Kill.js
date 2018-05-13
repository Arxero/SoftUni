function bunny(input) {
    let cordinates = input.pop().split(' ');
    let matrix = input.map(x => x.split(' ').map(Number));
    let damageDone = 0;
    let killedBunnies = 0;

    for (let cordinate of cordinates) {
        let splitter = cordinate.split(',').map(Number);
        let row = splitter[0];
        let col = splitter[1];

        if (matrix[row][col] > 0) {
            killedBunnies++;
            let damage = matrix[row][col];
            damageDone += damage;

            for (let i = Math.max(0, row - 1); i < Math.min(matrix.length - 1, row + 1); i++) {
                for (let j = Math.max(0, col - 1); j < Math.min(matrix[i].length - 1, col + 1); j++) {
                    matrix[i][j] -= damage;
                    if (matrix[i][j] < 0) {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] > 0) {
                killedBunnies++;
                damageDone += matrix[row][col];
            }
        }
    }

    console.log(damageDone);
    console.log(killedBunnies);
}
bunny([
    '10 10 10',
    '10 10 10',
    '10 10 10',
    '0,0'
]);

// bunny([
//     '5 10 15 20',
//     '10 10 10 10',
//     '10 15 10 10',
//     '10 10 10 10',
//     '2,2 0,1'
// ]);