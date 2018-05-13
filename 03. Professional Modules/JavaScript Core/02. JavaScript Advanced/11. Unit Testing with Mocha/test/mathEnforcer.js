let expect = require('chai').expect
const mathEnforcer = require('../04. Math Enforcer').mathEnforcer

describe('mathEnforcer', () => {

    describe('addFive', () => {
        it('should return undefined for "string"', () => {
            expect(mathEnforcer.addFive('string')).to.be.equal(undefined)
        });
        it('should return 10.2 for -5.2', () => {
            expect(mathEnforcer.addFive(-5.2)).to.be.equal(-5.2 + 5)
        });
    });

    describe('subtractTen', () => {
        it('should return undefined for "string"', () => {
            expect(mathEnforcer.subtractTen('string')).to.be.equal(undefined)
        });
        it('should return -15.2 for -5.2', () => {
            expect(mathEnforcer.subtractTen(-5.2)).to.be.equal(-5.2 - 10)
        });
    });

    describe('sum', () => {
        it('should return undefined for "string", 1', () => {
            expect(mathEnforcer.sum('string', 1)).to.be.equal(undefined)
        });
        it('should return undefined for 1, "string"', () => {
            expect(mathEnforcer.sum(1, 'string')).to.be.equal(undefined)
        });
        it('should return -10.5 for -5.5, -5.5', () => {
            expect(mathEnforcer.sum(-5, -5.5)).to.be.equal(-5 + -5.5)
        });
        it('should return 11 for 5.5, 5.5', () => {
            expect(mathEnforcer.sum(5.5, 5.5)).to.be.equal(5.5 + 5.5)
        });
    });
});