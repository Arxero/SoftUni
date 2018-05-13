function capitalize(input) {
    input = input.split(' ');
    
    for (let i = 0; i < input.length; i++) {
        let letters = input[i].split('');

        for (let j = 0; j < letters.length; j++) {
            let isUpper = /[A-Z]/.test(letters[j]);
            let isLower = /[a-z]/.test(letters[j]);

            if (isLower && j == 0) {
                letters[j] = letters[j].toUpperCase();
            }
            if (isUpper && j > 0) {
                letters[j] = letters[j].toLowerCase();
            }
        }
        input[i] = letters.join('');
    }
    console.log(input.join(' '));
}
// capitalize('Capitalize these words');
// capitalize('Was that Easy? tRY thIs onE for SiZe!');