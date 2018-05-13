function toImperial(n){
    let feet = 0;
    let inches = 0;
    if (n >= 12) {
        feet = Math.floor(n / 12);
        inches = n % 12;
    }
    else{
        inches = n;
    }
    console.log(`${feet}'-${inches}"`);
}