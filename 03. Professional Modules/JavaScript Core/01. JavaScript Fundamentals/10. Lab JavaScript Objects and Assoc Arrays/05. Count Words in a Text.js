function countWords(input) {
    let pattern = /[a-zA-Z0-9_]+/g;
    let words = input[0].match(pattern);
    let result = {};

    for (const word of words) {
        if (result[word]) {
            result[word]++;
        }
        else {
            result[word] = 1;
        }
    }
    console.log(JSON.stringify(result));

}
//countWords([`Far too slow, you're far too slow.`]);
//countWords([`JS devs use Node.js for server-side JS.-- JS for devs`]);