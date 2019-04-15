function solution(input) {
    let palindromes = []
    let isPalindromeFound = false

    for (let row of input) {
        let str = row.split(' ').join('')
        let strReversed = str.split('').reverse().join('')

        if (str == strReversed) {
            palindromes.push(str)
            isPalindromeFound = true
        }
    }

    if (isPalindromeFound == false) {
        console.log('No palindromes found')
    } else {
        console.log(palindromes.join(', '))
    }
}

