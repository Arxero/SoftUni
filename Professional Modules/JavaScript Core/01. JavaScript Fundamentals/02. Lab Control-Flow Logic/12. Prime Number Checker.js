function isPrime(n){
    let prime = true;
    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) {
            prime = false;
            break;
        }
    }
    console.log(prime && (n > 1));
}