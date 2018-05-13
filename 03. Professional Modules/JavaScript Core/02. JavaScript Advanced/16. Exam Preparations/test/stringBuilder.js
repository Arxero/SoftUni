let expect = require('chai').expect
let StringBuilder = require('../13. String Builder').StringBuilder

describe('StringBuilder', () => {
    let str
    beforeEach(() => {
        str = new StringBuilder('hello')
    });

    it('should contain all properties', () => {
        expect(Object.getPrototypeOf(str).hasOwnProperty('append')).to.be.equal(true)
        expect(Object.getPrototypeOf(str).hasOwnProperty('prepend')).to.be.equal(true)
        expect(Object.getPrototypeOf(str).hasOwnProperty('insertAt')).to.be.equal(true)
        expect(Object.getPrototypeOf(str).hasOwnProperty('remove')).to.be.equal(true)
        expect(Object.getPrototypeOf(str).hasOwnProperty('toString')).to.be.equal(true)
    });

    it('should instantiated with a passed in string argument or without anything', () => {
        expect(str.toString()).to.be.equal('hello')
    });

    it('should preppend work as expected', () => {
        str.prepend('man')
        expect(str.toString()).to.be.equal('manhello')
    });

    it('should insertAt work as expected', () => {
        str.insertAt('man', 0)
        expect(str.toString()).to.be.equal('manhello')
        expect(str._stringArray.length).to.be.equal(8)
    });

    it('should remove work as expected', () => {
        str.remove(0, 1)
        expect(str.toString()).to.be.equal('ello')
    });

    it('should throw error on non string element', () => {
        expect(() => str.prepend(0)).to.throw(TypeError)
    });
});
