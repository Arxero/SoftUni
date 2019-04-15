function solution(n1, n2, operator) {
    let result = 0
    switch (operator) {
        case 'multiply':
            result = (n1, n2) => n1 * n2
            console.log(result(n1, n2))
            break;
        case 'divide':
            result = (n1, n2) => n1 / n2
            console.log(result(n1, n2))
            break;
        case 'add':
            result = (n1, n2) => +n1 + +n2
            console.log(result(n1, n2))
            break;
        case 'subtract':
            result = (n1, n2) => n1 - n2
            console.log(result(n1, n2))
            break;
    }
}
