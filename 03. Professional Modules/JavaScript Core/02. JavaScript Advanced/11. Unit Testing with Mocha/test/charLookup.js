let expect = require('chai').expect
const lookupChar = require('../03. Char Lookup').lookupChar

describe('lookupChar()', () => {
    it('should return undefined for 9, 9', () => {
        expect(lookupChar(9, 9)).to.be.equal(undefined)
    });
    it('should return undefined for "string", "string"', () => {
        expect(lookupChar('string', 'string')).to.be.equal(undefined)
    });
    it('should return Incorrect index for "string", 10', () => {
        expect(lookupChar('string', 10)).to.be.equal('Incorrect index')
    });
    it('should return Incorrect index for "string", -10', () => {
        expect(lookupChar('string', -10)).to.be.equal('Incorrect index')
    });
    it('should return t for "string", 1', () => {
        expect(lookupChar('string', 1)).to.be.equal('t')
    });
    it('should return undefined for "string", 3.3', () => {
        expect(lookupChar('string', 3.3)).to.be.equal(undefined)
    });
});