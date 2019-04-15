function solution(input) {
    let arr = input.shift().split(' ')
    for (let commandLine of input) {
        let command = commandLine.split(' ')[0].toLowerCase()
        let element = commandLine.split(' ')[1]

        switch (command) {
            case 'add':
                arr.push(element)
                break;
            case 'remove':
                arr = arr.filter(x => x != element)
                break;
            case 'removeat':
                arr.splice(+element, 1)
                break;
            case 'insert':
                let index = commandLine.split(' ')[2]
                arr.splice(+index, 0, element)
                break;
        }
    }
    
    console.log(arr.join(' '))
}
