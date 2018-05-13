let expect = require('chai').expect
let createList = require('../17. Add  Swap Shift Left Right in List')

describe('createList', () => {
    let myList
    beforeEach(() => {
        myList = createList()
    });

    it('should add work as expected', () => {
        myList.add(1)
        myList.add('2')
        expect(myList.toString()).to.be.equal('1, 2')
    });

    it('should shiftLeft and shiftRight work as expected', () => {
        myList.add(1)
        myList.add('2')
        myList.shiftLeft()
        myList.shiftRight()
        expect(myList.toString()).to.be.equal('1, 2')
    });

    it('should swap work as expected', () => {
        myList.add(1)
        myList.add('2')
        expect(myList.swap('string', 1))
        expect(myList.swap(0, 1))
        expect(myList.toString()).to.be.equal('2, 1')
    });

    it('should not swap on nothing', () => {
        myList.add()
        expect(myList.swap(0, 1))
        expect(myList.swap(0, 0)).to.be.equal(false)
        expect(myList.toString()).to.be.equal('')
    });
    
    it('should return true somehow', () => {
        myList.add(3)
        myList.add('two')
        expect(myList.swap(1, 0)).to.be.equal(true)
    });
    
});