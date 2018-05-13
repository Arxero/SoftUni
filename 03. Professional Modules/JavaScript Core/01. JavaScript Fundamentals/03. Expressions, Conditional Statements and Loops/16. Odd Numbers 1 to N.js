function odds(n){
    for (let i = 1; i <= n; i++) {
        i % 2 != 0 ? console.log(`${i}`) : i;   
    }
}