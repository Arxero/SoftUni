function countWordsMaps(input) {
    let pattern = /[a-zA-Z0-9_]+/g;
    let words = input[0].match(pattern).map(x => x.toLowerCase());
    let results = new Map();
    let counter = 1;

    for (const word of words) {
        if (results.has(word)) {
            results.set(word, results.get(word) + 1);
        }
        else {
            results.set(word, 1);
        }
    }

    let sortedResults = Array.from(results.keys()).sort();
    for (const result of sortedResults) {
        console.log(`'${result}' -> ${results.get(result)} times`);
    }

}
//countWordsMaps([`Far too slow, you're far too slow.`]);
//countWordsMaps([`JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --`]);