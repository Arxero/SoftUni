function expedition(primary, secondary, overlay, start) {
    let steps = 1;
    let primaryRows = primary.length;
    let primaryCols = primary[0].length;
    let secondaryRows = secondary.length;
    let secondaryCols = secondary[0].length;

    for (let row of overlay) {
        editPrimary(row);
    }
    let currentPosition = [start[0], start[1]];
    let previousDirection;


    while (true) {
        if (currentPosition[0] + 1 < primaryRows && primary[currentPosition[0] + 1][currentPosition[1]] == 0 && previousDirection != 'up' ) {
            currentPosition = [currentPosition[0] + 1, currentPosition[1]];
            previousDirection = 'down';
        }
        else if (currentPosition[1] + 1 < primaryCols && primary[currentPosition[0]][currentPosition[1] + 1] == 0 && previousDirection != 'left') {
            currentPosition = [currentPosition[0], currentPosition[1] + 1];
            previousDirection = 'right';
        }
        else if (currentPosition[0] >  0 && primary[currentPosition[0] - 1][currentPosition[1]] == 0 && previousDirection != 'down') {
            currentPosition = [currentPosition[0] - 1, currentPosition[1]];
            previousDirection = 'up';
        }
        else if (currentPosition[1] > 0 && primary[currentPosition[0]][currentPosition[1] - 1] == 0 && previousDirection != 'right') {
            currentPosition = [currentPosition[0], currentPosition[1] - 1];
            previousDirection = 'left';
        }
        else {
            break;
        }
        steps++;
    }
    console.log(steps);
    definePosition(currentPosition);



    function definePosition(input) {
        let row = Number(input[0]);
        let col = Number(input[1]);
        if (row == 0) {
            console.log('Top');
        }
        else if (row == primaryRows - 1) {
            console.log('Bottom');
        }
        else if (col == 0) {
            console.log('Left');
        }
        else if (col == primaryCols - 1) {
            console.log('Right');
        }
        else if (row < primaryRows / 2 && col >= primaryCols / 2) {
            console.log('Dead end 1');
        }
        else if (row < primaryRows / 2 && col < primaryCols / 2) {
            console.log('Dead end 2');
        }
        else if (row >= primaryRows / 2 && col < primaryCols / 2) {
            console.log('Dead end 3');
        }
        else if (row >= primaryRows / 2 && col >= primaryCols / 2) {
            console.log('Dead end 4');
        }
    }


    function editPrimary(input) {
        let row = Number(input[0]);
        let col = Number(input[1]);
        for (let i = 0; i < secondaryRows; i++) {
            if (i + row < primaryRows) {
                for (let j = 0; j < secondaryCols; j++) {
                    if (primary[i + row][j + col] != undefined && secondary[i][j] == 1) {

                        if (primary[i + row][j + col] == 0) {
                            primary[i + row][j + col] = 1;
                        }
                        else {
                            primary[i + row][j + col] = 0;
                        }
                    }
                }
            }
        }
    }

}
// expedition(
//     [[1, 1, 0, 1, 1, 1, 1, 0],
//     [0, 1, 1, 1, 0, 0, 0, 1],
//     [1, 0, 0, 1, 0, 0, 0, 1],
//     [0, 0, 0, 1, 1, 0, 0, 1],
//     [1, 0, 0, 1, 1, 1, 1, 1],
//     [1, 0, 1, 1, 0, 1, 0, 0]],

//     [[0, 1, 1],
//     [0, 1, 0],
//     [1, 1, 0]],

//     [[1, 1],
//     [2, 3],
//     [5, 3]],

//     [0, 2]
// );