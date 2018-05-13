function printSquare(n = 5) {
    for (let i = 0; i < n; i++) {
        printStars(n);
    }

    function printStars(n) {
        console.log('*' + ' *'.repeat(n - 1));
    }
}