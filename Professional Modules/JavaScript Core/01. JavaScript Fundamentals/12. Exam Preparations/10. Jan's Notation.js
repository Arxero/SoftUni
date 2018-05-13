function notation(expression) {
    let stack = [];
    let instructionSet = {
        '+': (a, b) => a + b,
        '-': (a, b) => a - b,
        '*': (a, b) => a * b,
        '/': (a, b) => a / b,
    };

    for (let i of expression) {
        let instruction = instructionSet[i];
        if (instruction === undefined) {
            stack.push(i);
        } else {
            let [reg2, reg1] = [stack.pop(), stack.pop()];
            if (reg1 === undefined || reg2 === undefined) {
                console.log('Error: not enough operands!');
                return;
            }
            stack.push(instruction(reg1, reg2));
        }
    }

    if (stack.length > 1) {
        console.log('Error: too many operands!');
    } else {
        console.log(stack.pop());
    }
}
// notation(
//     [3,
//         4,
//         '+']
// );

// notation(
//     [31,
//         2,
//         '+',      
//         11,     
//         '/']
// );

// notation(
//     [-1,
//         1,
//         '+',
//         101,
//         '*',
//         18,
//         '+',
//         3,
//         '/']  
// );

// notation(
//     [7,
//         33,
//         8,
//         '-']
// );

// notation(
//     [15,

//         '/']
// );

// notation(
//     [5,
//         3,
//         4,
//         '*',
//         '-']
// );