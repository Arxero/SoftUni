let expect = require('chai').expect
let isOddOrEven = require('../02. Even Or Odd').isOddOrEven

describe('isOddOrEven()', () => {
    it('should return undefined for 9', () => {
        expect(isOddOrEven(9)).to.be.equal(undefined)
    });
    it('should return even for lele', () => {
        expect(isOddOrEven('lele')).to.be.equal('even')
    });
    it('should return even for lel', () => {
        expect(isOddOrEven('lel')).to.be.equal('odd')
    });

});
