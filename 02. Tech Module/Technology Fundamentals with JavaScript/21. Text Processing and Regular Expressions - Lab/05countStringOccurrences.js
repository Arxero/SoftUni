function solution(input, word) {
    input = input.split(' ')
    let wordOccurrencesCount = 0

    for (let row of input) {
       if (row == word) {
           wordOccurrencesCount++
       }
    }

    console.log(wordOccurrencesCount)
}