function solution(substring, input) {
    input = input.split(' ')
    let inputCopy = input.slice()

    input.forEach(currentWord => {
        if (currentWord.toLowerCase().includes(substring.toLowerCase())) {
            inputCopy = inputCopy.filter(x => x != currentWord)
        }
    })

    inputCopy.forEach((e, i) => {
        console.log(`idx[${i}] -> ${e}`)
    })
}
