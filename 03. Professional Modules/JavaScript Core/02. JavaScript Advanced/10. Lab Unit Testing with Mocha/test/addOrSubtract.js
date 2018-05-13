let expect = require('chai').expect
let createCalculator = require('../07. Add or Subtract').createCalculator

describe('createCalculator()', () => {
    let result
    beforeEach(() => {
        result = createCalculator()
    });

    it('should return 0 for get()', () => {
        expect(result.get()).to.be.equal(0)
    });
    it('should return 5 after add(2), add(3)', () => {
        result.add(2)
        result.add(3)
        expect(result.get()).to.be.equal(5)
    });
    it('should return -5 after substract(3), substract(2)', () => {
        result.subtract(3)
        result.subtract(2)
        expect(result.get()).to.be.equal(-5)
    });
    it('should return 4.2 after add(5.3), substract(1.1)', () => {
        result.add(5.3)
        result.subtract(1.1)
        expect(result.get()).to.be.equal(5.3 - 1.1)
    });
    it('should return 5 for add("10"), substract("5"), add(0)', () => {
        result.add('10')
        result.add(0)
        result.subtract('5')
        expect(result.get()).to.be.equal(5)
    });
});