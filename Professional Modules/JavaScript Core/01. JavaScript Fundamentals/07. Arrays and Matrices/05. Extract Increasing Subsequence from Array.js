function getSubsequence(input) {
    //let result = input.filter((a, b) => a >= b);
    let result = [];
    result.push(input[0]);
    for (let i = 0; i < input.length; i++) {
        if (input[i + 1] >= input[i] && input[i + 1] >= input[0]) {
            result.push(input[i + 1]);
        }
    }
    console.log(result.join('\n'));
}
//getSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]);
//getSubsequence([1, 2, 3, 4]);
//getSubsequence([20, 3, 2, 15, 6, 1]);
