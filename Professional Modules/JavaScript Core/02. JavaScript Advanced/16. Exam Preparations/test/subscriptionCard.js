let expect = require('chai').expect
let SubscriptionCard = require('../29. Subscription Card')

describe('SubscriptionCard', () => {
    let card
    beforeEach(() => {
        card = new SubscriptionCard('Pesho', 'Petrov', '00000000')
    });

    it('should have all properties', () => {
        expect(card.hasOwnProperty("_firstName")).to.be.true;
        expect(card.hasOwnProperty("_lastName")).to.be.true;
        expect(card.hasOwnProperty("_SSN")).to.be.true;
        expect(card.hasOwnProperty("_blocked")).to.be.true;
        expect(card.addSubscription).to.exist
        expect(card.isValid).to.exist
        expect(card.block).to.exist
        expect(card.unblock).to.exist
    });

    it('should addSubscription work as expected', () => {
        expect(card._subscriptions.length).to.be.equal(0)
        card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
        expect(card._subscriptions.length).to.be.equal(1)
    });

    it('should isValid to work as expected', () => {
        card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
        expect(card.isValid('*', new Date('2018-04-22'))).to.be.equal(true)
        card.block()
        expect(card.isValid('*', new Date('2018-04-22'))).to.be.equal(false)  
    });
});