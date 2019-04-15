function solution(number, operator, anotherNumber) {
    switch (operator) {
        case '+':
            console.log((+number + +anotherNumber).toFixed(2))
            break;
        case '-':
            console.log((number - anotherNumber).toFixed(2))
            break;
        case '*':
            console.log((number * anotherNumber).toFixed(2))
            break;
        case '/':
            console.log((number / anotherNumber).toFixed(2))
            break;
    }
}
