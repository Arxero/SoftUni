function multiplication(input) {
    let pattern = /(-*\d+)\s*\*\s*([-*\d+][.\d]*)/g;
    let patternSingle = /(-*\d+)\s*\*\s*([-*\d+][.\d]*)/;
    let result = pattern.exec(input);

    while (result !== null) {
        let num1 = Number(result[1]);
        let num2 = Number(result[2]);
        let multiplication = num1 * num2;
        input = input.replace(patternSingle, multiplication);
        result = pattern.exec(input);
    }
    console.log(input);
}
// multiplication('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).');