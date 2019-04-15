function solution(input) {
    input = input.split(' ')
    let deers = []
    let inputCopy = input.slice()

    input.forEach(word => {
        if (word.startsWith('*') && word.endsWith('*') && (word.charCodeAt(1) >= 65 && word.charCodeAt(1) <= 90)) {
            let smallCounter = 0

            word.substring(2, word.length - 1).split('').forEach(l => {
                if (l.charCodeAt(0) >= 97 && l.charCodeAt(0) <= 122) {
                    smallCounter++
                }
            })
            if (smallCounter == word.length - 3) {
                deers.push(word)
                inputCopy = inputCopy.filter(x => x != word)
            }
        }
    })

    console.log(deers.join(', '))
    console.log('*'.repeat(20))
    console.log(inputCopy.join(' '))
}
solution(`Oh my *Rudolf* dwarfs! This *Dasher* year's christmas *Prancer is about to be Comet* ruined because Santa has lost his deer and.`)