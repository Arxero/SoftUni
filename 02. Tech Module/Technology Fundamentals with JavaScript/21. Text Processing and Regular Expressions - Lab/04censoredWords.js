function solution(input, word) {
    let wordToReplace = '*'.repeat(word.length)
    input = input.replace(word, wordToReplace)
    
    while (input.includes(word)) {
        input = input.replace(word, wordToReplace)
    }

    console.log(input)
}