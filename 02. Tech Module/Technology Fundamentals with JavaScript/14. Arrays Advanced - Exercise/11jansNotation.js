function solution(input) {
    if (input.length <= 2) {
        console.log('Error: not enough operands!')
        return
    }

    while (input.length > 1) {
        let numberCount = 0
        for (let i = 0; i < input.length; i++) {
            if (typeof input[i] == 'string') {
                let n1 = input[i - 2]
                let n2 = input[i - 1]
                let operator = input[i]
                if (n1 != undefined) {
                    let result = calculate(n1, n2, operator)

                    input.splice(i - 2, 3, result)
                    i = i - 2

                    if (!input.includes('+') &&
                        !input.includes('-') &&
                        !input.includes('*') &&
                        !input.includes('/') &&
                        input.length > 1) {
                        console.log('Error: too many operands!')
                        return
                    }
                } else {
                    console.log('Error: not enough operands!')
                    return
                }
            } else {
                if (!input.includes('+') &&
                    !input.includes('-') &&
                    !input.includes('*') &&
                    !input.includes('/') &&
                    input.length > 1) {
                    numberCount++
                }

            }
        }
        if (numberCount == 3) {
            console.log('Error: too many operands!')
            return
        }

    }

    console.log(input[0])

    function calculate(n1, n2, operator) {
        let result = 0
        switch (operator) {
            case '+':
                result = n1 + n2
                break;
            case '-':
                result = n1 - n2
                break;
            case '*':
                result = n1 * n2
                break;
            case '/':
                result = n1 / n2
                break;
        }
        return result
    }
}
//solution([3, 4, '+'])
//solution([5, 3, 4, '*', '-'])
//solution([7, 33, 8, '-'])
//solution([15, '/'])
solution([-1, 1, '+', 101, '*', 18, '+', 3, '/'])