function concatReversed(input) {
//(input) => Array.from(input.join('')).reverse().join(''); - short version
    for (let i = 0; i < input.length; i++) {
        let currentWord = input[i];
        let reversed = '';
        for (let j = currentWord.length - 1; j >= 0; j--) {
            reversed += currentWord[j];
        }
        input.splice(i, 1, reversed);
    }
    console.log(input.reverse().join(''));
}
//concatReversed(['I', 'am', 'student']);
