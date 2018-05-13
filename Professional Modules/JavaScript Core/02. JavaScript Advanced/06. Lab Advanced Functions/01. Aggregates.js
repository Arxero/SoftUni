function aggregate(input) {
    console.log(`Sum = ${input.reduce((a, b) => a + b)}`);
    console.log(`Min = ${input.sort((a, b) => a > b)[0]}`);
    console.log(`Max = ${input.sort((a, b) => b > a)[0]}`);
    console.log(`Product = ${input.reduce((a, b) => a * b)}`);
    console.log(`Join = ${input.reverse().join('')}`);
}
