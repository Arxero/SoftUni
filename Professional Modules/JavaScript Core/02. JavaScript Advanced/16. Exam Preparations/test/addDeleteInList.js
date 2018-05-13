let expect = require('chai').expect
let list = require('../16. Add Delete in List')

describe('list', () => {

    it('should work on empty input', () => {
        expect(list.toString()).to.be.equal('')
    });

    it('should add work as expected', () => {
        list.add('')
        list.add(-1.2)
        list.add('string')
        list.delete(2)
        expect(list.toString()).to.be.equal(', -1.2')
    });

    it('should return undefined on invalid index', () => {
        expect(list.delete('-10.5')).to.be.equal(undefined)
    });
});