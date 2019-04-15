function solution(word, input) {
    if (input.split(' ').map(x => x.toLowerCase()).includes(word.toLowerCase())) {
        console.log(word)
        return
    }
    console.log(word + ' not found!')
}
