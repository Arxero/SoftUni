function solution(input) {
    let descriptions = input.shift().split(' | ')
    let words = input.shift().split(' | ')
    let command = input[0]
    let dictionary = {}

    for (let description of descriptions) {
        let [word, actualDescription] = description.split(': ')

        if (!dictionary.hasOwnProperty(word)) {
            let actualDescriptions = []
            actualDescriptions.push(actualDescription)
            dictionary[word] = actualDescriptions
        } else {
            let oldActualDescriptions = dictionary[word]
            oldActualDescriptions.push(actualDescription)
            dictionary[word] = oldActualDescriptions
        }
    }


    dictionary = Object.entries(dictionary)
        .sort((a, b) => a[0].localeCompare(b[0]))
    dictionary.forEach(x => x[1].sort((a, b) => b.length - a.length))


    if (command == 'List') {
        let result = []
        dictionary.forEach(x => result.push(x[0]))
        console.log(result.join(' '))
    } else {
        //console.log(dictionary)
        for (let word of words) {
            dictionary.forEach(x => {
                if (word == x[0]) {
                    console.log(word)
                    x[1].forEach(d => console.log(' -' + d))
                }
            })
        }
    }
}
// solution(['programmer: an animal, which turns coffee into code | developer: a magician',
//     'Pesho | Gosho',
//     'List'])

solution(['tackle: the equipment required for a task or sport | code: write code for a computer program | bit: a small piece, part, or quantity of something | tackle: make determined efforts to deal with a problem | bit: a short time or distance',
    'bit | code | tackle',
    'End']
)