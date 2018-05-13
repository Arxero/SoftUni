function printDeckOfCards(input) {
    function createCard(card, suit) {
        const VALID_CARDS = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
        const VALID_SUITS = {
            'S': '\u2660',
            'H': '\u2665',
            'D': '\u2666',
            'C': '\u2663'
        }
        if (VALID_CARDS.indexOf(card) < 0 || !VALID_SUITS.hasOwnProperty(suit)) {
            throw new Error('Invalid input data!')
        }
        return {
            card: card,
            suit: suit,
            toString: function () {
                return card + VALID_SUITS[suit]
            }
        }
    }

    for (let i = 0; i < input.length; i++) {
        let card = input[i].substring(0, input[i].length - 1)
        let suit = input[i][input[i].length - 1]
        try {
            input[i] = createCard(card , suit)
        } catch (ex) {
            console.log('Invalid card: ' + input[i])
            return
        }
    }
    console.log(input.join(' '))
}
//printDeckOfCards(['AS', '10D', 'KH', '2C']);
