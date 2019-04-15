function solution(input) {
    let collection = input.shift().split(' ')
    input = input.filter(x => x != '')

    for (let i = 0; i < input.length - 1; i++) {
        let splitter = input[i].split(' ')
        let command = splitter[0]

        switch (command) {
            case 'Delete':
                let deleteIndex = +splitter[1]
                if (deleteIndex >= 0 && deleteIndex <= collection.length - 1) {
                    collection.splice(deleteIndex + 1, 1)
                }
                break
            case 'Swap':
                let word1Swap = splitter[1]
                let word2Swap = splitter[2]
                if (collection.includes(word1Swap) && collection.includes(word2Swap)) {
                    let indexOfWord1 = collection.indexOf(word1Swap)
                    let indexOfWord2 = collection.indexOf(word2Swap)
                    collection.splice(indexOfWord1, 1, word2Swap)
                    collection.splice(indexOfWord2, 1, word1Swap)
                }
                break
            case 'Put':
                let wordPut = splitter[1]
                let wordPutIndex = +splitter[2]
                if (wordPutIndex > 0 && wordPutIndex <= collection.length + 1) {
                    collection.splice(wordPutIndex - 1, 0, wordPut)
                }
                break
            case 'Sort':
                collection = collection.sort((a, b) => b.toLowerCase().localeCompare(a.toLowerCase()))
                break
            case 'Replace':
                let word1Replace = splitter[1]
                let word2Replace = splitter[2]
                if (collection.includes(word2Replace)) {
                    let indexOfWord2Replace = collection.indexOf(word2Replace)
                    collection.splice(indexOfWord2Replace, 1, word1Replace)
                }
                break
        }
    }

    console.log(collection.join(' '))
}
solution([
    'Congratulations! You last also through the have challenge!',
    'Swap have last',
    'Replace made have',
    'Delete 2',
    'Put it 1',
    'Put it 1',
    'Stop',
    ''
])