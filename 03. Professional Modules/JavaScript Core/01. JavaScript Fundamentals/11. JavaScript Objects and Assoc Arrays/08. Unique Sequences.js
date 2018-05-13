function uniqueSeq(input) {
    let results = [];

    for (let row of input) {
        let arr = JSON.parse(row).sort((a, b) => b - a);
        results.push(arr);
    }

    for (let i = 0; i < results.length; i++) {
        let currentArray = results[i];

        for (let j = i + 1; j < results.length; j++) {
            if (compareArrs(currentArray, results[j])) {
                results.splice(j, 1);
                j--;
            }
        }
    }

    results.sort((a, b) => a.length - b.length);
    results.forEach(x => console.log(`[${x.join(', ')}]`));

    function compareArrs(a, b) {
        if (a.length == b.length) {
            for (let i = 0; i < a.length; i++) {
                if (a[i] != b[i]) {
                    return false;
                }
            }
        }
        else {
            return false;
        }
        return true;
    }

}
// uniqueSeq([
//     '[-3, -2, -1, 0, 1, 2, 3, 4]',
//     '[10, 1, -17, 0, 2, 13]',
//     '[4, -3, 3, -2, 2, -1, 1, 0]'
// ]);