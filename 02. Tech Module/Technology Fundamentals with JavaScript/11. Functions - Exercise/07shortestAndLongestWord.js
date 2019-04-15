function solution(input) {
    input = input.split(' ').join(',')
        .split(',').join('?')
        .split('?').join('.')
        .split('.').filter(x => x != '')

    let shortestWord = input[0]
    input.forEach(x => {
        if (x.length < shortestWord.length) {
            shortestWord = x
        }
    })

    let longestWord = ''
    input.forEach(x => {
        if (x.length > longestWord.length) {
            longestWord = x
        }
    })

    console.log('Longest -> ' + longestWord)
    console.log('Shortest -> ' + shortestWord)
}
