function solution(n, n2) {
    
    function calcFactorial(n) {
        let factorialOfN = 1
        while (n > 0) {
            factorialOfN *= n
            n--
        }
        return factorialOfN
    }
    
    console.log((calcFactorial(n) / calcFactorial(n2)).toFixed(2))
}
