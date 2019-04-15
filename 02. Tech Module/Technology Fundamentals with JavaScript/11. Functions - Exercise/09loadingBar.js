function solution(input) {
    let n = input / 10
    let percentageSign = ''
    let dotSign = ''

    for (let i = 1; i <= 10; i++) {
        if (i >= 1 && i <= n) {
            percentageSign += '%'
        } else {
            dotSign += '.'
        }
    }

    if (n < 10) {
        console.log(input + '% [' + percentageSign + dotSign + ']')
        console.log('Still loading...')
    } else {
        console.log('100% Complete!')
        console.log('[' + percentageSign + ']')
    }
}
