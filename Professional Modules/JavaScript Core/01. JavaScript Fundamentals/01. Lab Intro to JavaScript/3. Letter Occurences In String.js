function occurrences(string, letter){
    let count = 0;
    for (let index = 0; index < string.length; index++) {
        const element = string[index];
        if (element == letter) {
            count++;
        }
    }
    console.log(count);
}