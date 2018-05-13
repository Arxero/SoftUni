function sort(input) {
    input.sort((a, b) => a.length - b.length || a.toLowerCase().localeCompare(b.toLowerCase()));
    console.log(input.join('\n'));
}
//sort(['alpha', 'beta', 'gamma']);
//sort(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
//sort(['test', 'Deny', 'omen', 'Default']);
