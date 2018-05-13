function averageModify(n) {

    while (getAverage(n) <= 5) {
        n += '9';
    }
    console.log(n);

    function getAverage(n) {
        let numbers = n.toString();
        let sum = 0;
        for (let i = 0; i < numbers.length; i++) {
            sum += Number(numbers[i]);
        }
        let average = sum / numbers.length;
        return average;
    }
}
//averageModify(101);
//averageModify(5835);