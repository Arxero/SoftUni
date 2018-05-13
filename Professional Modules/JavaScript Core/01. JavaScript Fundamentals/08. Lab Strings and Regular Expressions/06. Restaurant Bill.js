function bill(input) {
    let products = [];
    let sum = [];
    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0) {
            products.push(input[i]);
        }
        else {
            sum.push(Number(input[i]));
        }
    }
    console.log(`You purchased ${products.join(', ')} for a total sum of ${sum.reduce((a, b) => a + b)}`);
}
//bill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);