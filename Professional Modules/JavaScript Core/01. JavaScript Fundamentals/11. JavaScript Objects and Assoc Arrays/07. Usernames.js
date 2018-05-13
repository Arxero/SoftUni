function usernames(input) {
    let results = new Set();

    for (let row of input) {
        results.add(row);
    }

    let OrderByLength = [...results].sort((a, b) => sortNames(a, b));

    function sortNames(a, b) {
        if (a.length != b.length) {
            return(a.length - b.length)
        }
        else{
            return a.localeCompare(b);
        }
    }
    console.log([...OrderByLength].join('\n'));
}
// usernames([
//     'Ashton',
//     'Ashton',
//     'Kutcher',
//     'Ariel',
//     'Lilly',
//     'Keyden',
//     'Aizen',
//     'Billy',
//     'Braston',
// ]);