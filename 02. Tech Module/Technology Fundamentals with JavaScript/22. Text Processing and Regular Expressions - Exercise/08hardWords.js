function solution(input) {
    let wordsToFill = input.pop()
    input = input[0].split(' ')
    
    for (let i = 0; i < input.length; i++) {
        let currentWord = input[i]
        if (currentWord.startsWith('_')) {
            let punctuationSign = ''
            if (currentWord.endsWith('.') || currentWord.endsWith(',')) {
                punctuationSign = currentWord[currentWord.length - 1]
                currentWord = currentWord.substring(0, currentWord.length - 1)
            }

            for (let word of wordsToFill) {
                if (currentWord.length == word.length) {
                    input.splice(i, 1, word + punctuationSign)
                }
            }
        }
    }

    console.log(input.join(' '))
}
