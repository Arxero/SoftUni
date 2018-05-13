function ocurrance(input, word) {
    let pattern = new RegExp(`${word}\\b`, 'gi');
    let match = pattern.exec(input);
    let counter = 0;

    while (match) {
        counter++;
        match = pattern.exec(input);
    }
    console.log(counter);
}
// ocurrance('The waterfall was so high, that the child couldn’t see its peak.', 'the');
// ocurrance('How do you plan on achieving that? How? How can you even think of that?', 'how');
// ocurrance('There was one. Therefore I bought it. I wouldn’t buy it otherwise.', 'there');