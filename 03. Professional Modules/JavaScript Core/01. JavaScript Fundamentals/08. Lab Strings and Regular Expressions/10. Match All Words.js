function matchWords(input) {
    let pattern = /\w+/gm;
    let found = input.match(pattern);
    console.log(found.join('|'));
}
//matchWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');
//matchWords('_(Underscores) are also word characters');