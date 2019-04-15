function solution(input, commands) {

    for (let commandLine of commands) {
        commandLine = commandLine.split(' ')
        let command = commandLine[0]

        switch (command) {
            case 'add':
                let indexAdd = commandLine[1]
                let element = commandLine[2]
                input.splice(indexAdd, 0, +element)
                break;
            case 'addMany':
                let indexAddMany = commandLine[1]
                let numbersToAdd = commandLine.slice(2).map(x => +x)
                numbersToAdd.forEach(x => input.splice(indexAddMany++, 0, x))
                break;
            case 'contains':
                let n = commandLine[1]
                console.log(input.indexOf(+n))
                break;
            case 'remove':
                let indexRemove = +commandLine[1]
                input.splice(indexRemove, 1)
                break;
            case 'shift':
                let positions = +commandLine[1]
                for (let i = 0; i < positions; i++) {
                    let first = input.shift()
                    input.push(first)
                }
                break;
            case 'sumPairs':
                let result = []
                while (input.length > 0) {
                    let pairSum = input.splice(0, 2).reduce((a, b) => a + b, 0)
                    result.push(pairSum)
                }
                input = result.slice()
                break;
            case 'print':
                console.log(input)
                break;
        }
    }
}
