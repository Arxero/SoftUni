function isOddOrEven(n){
    let isInt = n % 1 === 0;
    if (isInt) {
        console.log(n % 2 == 0 ? "even" : "odd");    
    }
    else{
        console.log('invalid');
    }  
}