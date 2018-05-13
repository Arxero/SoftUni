let expect = require('chai').expect
let makeList = require('../15. Add Left  Right  Clear in List').makeList

describe('makeList', () => {
    let list
    beforeEach(() => {
        list = makeList()
    });

    it('should have all functions', () => {
        expect(list.addLeft).to.exist
        expect(list.addRight).to.exist
        expect(list.clear).to.exist
        expect(list.toString).to.exist
    });

    it('should addRight and addLeft work as expected', () => {
        list.addRight(-1.5)
        list.addLeft('string')
        expect(list.toString()).to.be.equal('string, -1.5')
    });

    it('should clear work as expected', () => {
        list.addLeft(1)
        list.clear()
        expect(list.toString()).to.be.equal('')
    });

    it('should return empty on non content', () => {
        expect(list.toString()).to.be.equal('')
        list.addLeft('')
        list.addRight('')
        expect(list.toString()).to.be.equal(', ')
    });
});