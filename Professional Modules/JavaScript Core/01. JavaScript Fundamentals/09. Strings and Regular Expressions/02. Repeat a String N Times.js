function repeat(input, times) {
    let result = '';
    for (let i = 0; i < times; i++) {
        result = result.concat(input);
    }
    console.log(result);
}
// repeat('repeat', '5');