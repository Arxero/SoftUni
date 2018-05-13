function dna(n){
    let helix = 'ATCGTTAGGG';
    let counter = 0;

    for(let i = 0; i < n; i++) {
        if(i % 4 == 0) { //4 because 4 rows needed
            console.log(`**${helix[counter % 10]}${helix[counter % 10 + 1]}**`); // 10 because helix is 10 symbols
        } else if(i % 4 == 1) {
            console.log(`*${helix[counter % 10]}--${helix[counter % 10 + 1]}*`);
        } else if(i % 4 == 2) {
            console.log(`${helix[counter % 10]}----${helix[counter % 10 + 1]}`);
        } else if(i % 4 == 3) {
            console.log(`*${helix[counter % 10]}--${helix[counter % 10 + 1]}*`);
        }
        counter += 2
    }
}
//dna(4);