function toUppercase(input) {
    let pattern = /\w+/gi;
    let match = input.match(pattern);

    for (let i = 0; i < match.length; i++) {
        match[i] = match[i].toUpperCase();
    }
    console.log(match.join(', '));
}
//toUppercase('Hi, how are you?');