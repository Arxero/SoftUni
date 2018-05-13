function kNumbers(input) {
    let k = input[0];
    let first = input.slice(1, k + 1);
    let last = input.slice(input.length - k, input.length);
    console.log(first.join(' '));
    console.log(last.join(' '));
}
//kNumbers([2, 7, 8, 9]);
//kNumbers([3, 6, 7, 8, 9]);