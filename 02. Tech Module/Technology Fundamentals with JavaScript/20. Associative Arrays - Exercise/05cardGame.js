function solution(input) {
    let result = {}

    for (let row of input) {
        let [person, cards] = row.split(': ')
        cards = cards.split(', ')

        if (!result.hasOwnProperty(person)) {
            result[person] = cards.filter((v, i, s) => s.indexOf(v) == i)
        } else {
            let oldCards = result[person]
            let newCards = cards.filter((v, i, s) => s.indexOf(v) == i)
            let combinedCards = oldCards.concat(newCards)
            result[person] = combinedCards
        }
    }

    for (let person in result) {
        let currentCards = result[person].filter((v, i, s) => s.indexOf(v) == i)
        let currentDeskPower = 0

        for (let card of currentCards) {
            card = card.split('')
            let type = card.pop()
            let power = card.join('')
            
            switch (power) {
                case 'J': power = 11; break;
                case 'Q': power = 12; break;
                case 'K': power = 13; break;
                case 'A': power = 14; break;
            }
            switch (type) {
                case 'S': type = 4; break;
                case 'H': type = 3; break;
                case 'D': type = 2; break;
                case 'C': type = 1; break;
            } 
            currentDeskPower += +power * type
        }
        result[person] = currentDeskPower 
    }

    Object.entries(result).forEach(x => console.log(x[0] + ': ' + x[1]))
}
