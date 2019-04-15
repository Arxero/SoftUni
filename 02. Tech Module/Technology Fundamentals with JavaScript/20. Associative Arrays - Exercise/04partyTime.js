function solution(input) {
    let indexOfParty = input.indexOf('PARTY')
    let reservations = input.slice(0, indexOfParty)

    for (let i = indexOfParty + 1; i < input.length; i++) {
        let guest = input[i]
        let indexOfGuest = reservations.indexOf(guest)
        reservations.splice(indexOfGuest, 1)
    }

    console.log(reservations.length)
    reservations.forEach(x => {
        if (Number.isInteger(+x[0])) {
            console.log(x)
        }
    })
    
    reservations.forEach(x => {
        if (!Number.isInteger(+x[0])) {
            console.log(x)
        }
    })
}
solution([
    '7IK9Yo0h',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc',
    'tSzE5t0p',
    '8SzE5t0p',
    'PARTY',
    '9NoBUajQ',
    'Ce8vwPmE',
    'SVQXQCbc'
])
