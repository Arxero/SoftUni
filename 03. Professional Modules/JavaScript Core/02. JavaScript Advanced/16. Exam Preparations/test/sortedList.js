let expect = require('chai').expect
let SortedList = require('../18. Sorted List')

describe('SortedList', () => {
    let list
    beforeEach(() => {
        list = new SortedList()
    });

    it('should have all functoins', () => {
        expect(Object.getPrototypeOf(list).hasOwnProperty('add')).to.be.equal(true)
        expect(Object.getPrototypeOf(list).hasOwnProperty('remove')).to.be.equal(true)
        expect(Object.getPrototypeOf(list).hasOwnProperty('get')).to.be.equal(true)
        expect(Object.getPrototypeOf(list).hasOwnProperty('vrfyRange')).to.be.equal(true)
        expect(Object.getPrototypeOf(list).hasOwnProperty('sort')).to.be.equal(true)
        expect(Object.getPrototypeOf(list).hasOwnProperty('size')).to.be.equal(true)
    });

    it('should add and remove works as expected', () => {
        list.add(1)
        list.remove(0)
        list.add(2)
        list.add(1)
        expect(list.size).to.be.equal(2)
        expect(list.get(0)).to.be.equal(1)
        expect(list.list[0]).to.be.equal(1)
    });

    it('should throw as in invalid indexes', () => {
        expect(() => list.remove()).to.throw(Error)
        expect(() => list.get()).to.throw(Error)
        list.add(1)
        expect(() => list.remove(-1)).to.throw(Error)
        expect(() => list.get(20)).to.throw(Error)
    });
});
