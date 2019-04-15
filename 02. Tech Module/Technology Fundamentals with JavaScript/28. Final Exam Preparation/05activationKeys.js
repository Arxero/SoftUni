function solution(input) {
    input = input[0].split('&')
    let validKeyRegex = /^[0-9A-Za-z]{16}$|^[0-9A-Za-z]{25}$/
    let result = []

    for (let key of input) {
        let numbersRegex = /[0-9]/g
        let groupsRegex = ''
        let matches = ''
        let matchedNumbers = []

        if (validKeyRegex.test(key)) {

            if (key.length == 16) {
                groupsRegex = /[0-9A-Za-z]{4}/g
                matches = key.match(groupsRegex).join('-').toUpperCase()
                matchedNumbers = key.match(numbersRegex).map(x => Math.abs(x - 9))
                matches = matches.split('')

                matches.forEach((e, i) => {
                    if (parseInt(e) || e == '0') {
                        matches.splice(i, 1, matchedNumbers.shift())
                    }
                })
                result.push(matches.join(''))
            } else {
                groupsRegex = /[0-9A-Za-z]{5}/g
                matches = key.match(groupsRegex).join('-').toUpperCase()
                matchedNumbers = key.match(numbersRegex).map(x => Math.abs(x - 9))
                // console.log(matches)
                matches = matches.split('')
                // console.log(matchedNumbers)
                
                matches.forEach((e, i) => {
                    if (parseInt(e) || e == '0') {
                        matches.splice(i, 1, matchedNumbers.shift())
                        // matches[i] = matchedNumbers
                        // console.log(e)
                    }
                })
                
                result.push(matches.join(''))
                // console.log(matches.join(''))
            }

        }
    }

    if (result.length > 0) {
        console.log(result.join(', '))
    }
}
// solution(['xPt8VYhUDalilWLvb6uMSGEEf&KWQ{R.@/HZCbbV++1o]V+oG@@fF^93&y6fT5EGFgZHqlFiS']
// )

solution(['t1kjZU764zIME6Dl9ryD0g1U8&-P4*(`Q>:x8\\yE1{({X/Hoq!gR.&rg93bXgkmILW188m&KroGf1prUdxdA4ln&U3WH9kXPY0SncCfs'])