let expect = require('chai').expect
let Sumator = require('../14. Sumator Class').Sumator

describe('Sumator', () => {
    let sumator
    beforeEach(() => {
        sumator = new Sumator()
    });

    it('shouold have all functions', () => {
        expect(Object.getPrototypeOf(sumator).hasOwnProperty('add')).to.be.equal(true)
        expect(Object.getPrototypeOf(sumator).hasOwnProperty('sumNums')).to.be.equal(true)
        expect(Object.getPrototypeOf(sumator).hasOwnProperty('removeByFilter')).to.be.equal(true)
        expect(Object.getPrototypeOf(sumator).hasOwnProperty('toString')).to.be.equal(true)
    });

    it('should contains a property data that is initialized to an empty array.', () => {
        expect(typeof sumator.data).to.be.equal('object')
        expect(sumator.data.length).to.be.equal(0)
    });

    it('should add work as expected', () => {
        sumator.add(1.5)
        sumator.add('2')
        expect(sumator.toString()).to.be.equal('1.5, 2')
    });

    it('should sumNums work as expected', () => {
        expect(sumator.sumNums('2')).to.be.equal(0)
        sumator.add(1)
        sumator.add(2)
        sumator.add('2')
        expect(sumator.sumNums()).to.be.equal(3)
    });

    it('should removeByFilter works as expected', () => {
        sumator.add(1)
        sumator.add(2)
        sumator.removeByFilter(x => x % 2 === 0)
        expect(sumator.toString()).to.be.equal('1')
    });

    it('should return (empty) on items in data', () => {
        expect(sumator.toString()).to.be.equal('(empty)')
    });
});