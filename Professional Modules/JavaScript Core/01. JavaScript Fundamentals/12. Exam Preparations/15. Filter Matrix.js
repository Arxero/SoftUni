function filter(input) {
    let n = Number(input.pop());
    let numbers = input.join(' ').split(' ');
    let counter = 1;

    for (let i = 0; i < numbers.length; i++) {
        let a = numbers[i];
        let b = numbers[i + 1];
        if (a == b) {
            counter++;
            if (counter == n) {
                for (let j = i + 1; j > i + 1 - n; j--) {
                    numbers[j] = ' ';
                }
                counter = 1;
            }
        }
        else {
            counter = 1;
        }
    }

    let result = [];
    let index = -1;
    for (let i = 0; i < input.length; i++) {
        let row = input[i].split(' ');
        let outputRow = [];
        for (let j = 0; j < row.length; j++) {
            if (numbers[++index] != ' ') {
                outputRow.push(numbers[index]);
            }
        }
        result.push(outputRow);
    }

    for (let row of result) {
        if (row.length > 0) {
            console.log(row.join(' '));
        }
        else {
            console.log('(empty)');
        }
    }
}
// filter([
//     '3 3 3 2 5 9 9 9 9 1 2',
//     '1 1 1 1 1 2 5 8 1 1 7',
//     '7 7 1 2 3 5 7 4 4 1 2',
//     '2'
// ]);

// filter([
//     '1 2 3 3',
//     '3 5 7 8',
//     '3 2 2 1',
//     '3'
// ]);

// filter([
// '2 1 1 1',
// '1 1 1',
// '3 7 3 3 1',
// '2'
// ]);