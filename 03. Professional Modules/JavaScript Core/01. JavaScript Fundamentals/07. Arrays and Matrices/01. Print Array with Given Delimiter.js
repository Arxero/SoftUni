function delimiterArray(input){
    let delimiter = input[input.length - 1];
    input = input.join(`${delimiter}`)
    console.log(input.slice(0, input.length - 2));
}
//delimiterArray(['One', 'Two', 'Three', 'Four', 'Five', '-']);