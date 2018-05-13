function spice(input) {
    let startingYield = Number(input);
    let counter = 0;
    let minedYield = 0;

    while (startingYield >= 100) {
        minedYield += startingYield - 26;
        counter++;
        startingYield -= 10;
        
    }
    console.log(`${counter}`);
    if (minedYield >= 26) {
        console.log(`${minedYield - 26}`);
    }
    else{
        console.log(`${minedYield}`);
    }
    
}
// spice([
//     '111'
// ]);