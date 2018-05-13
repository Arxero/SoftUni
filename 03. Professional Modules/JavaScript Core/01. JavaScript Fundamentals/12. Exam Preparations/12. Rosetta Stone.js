function rosetta(input) {
    let n = Number(input.shift());
    let template = input.slice(0, n).map(x => x.split(' ').map(Number));
    let matrix = input.splice(n).map(x => x.split(' ').map(Number));
    let result = '';

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[0].length; col++) {
            let current = matrix[row][col];
            let modifier = template[row % template.length][col % template[0].length];
            result += String.fromCharCode(((current + modifier) % 27) + 64);
        }
    }
    result = result.replace(/@/g, ' ');
    console.log(result);
    console.log(0 % template.length);
}
rosetta([
    '2',
    '59 36',
    '82 52',
    '4 18 25 19 8',
    '4 2 8 2 18',
    '23 14 22 0 22',
    '2 17 13 19 20',
    '0 9 0 22 22'
]);