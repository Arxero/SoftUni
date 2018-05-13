let expect = require("chai").expect
const isSymmetric = require('../05. Check for Symmetry')

describe('isSymmetric(arr)',  () => {
    it('should return true [1, 2, 3, 3, 2, 1]', () => {
        expect(isSymmetric([1, 2, 3, 3, 2, 1])).to.be.equal(true)
    })
    it('should return false [1, 2, 3, 4, 2, 1]', () => {
        expect(isSymmetric([1, 2, 3, 4, 2, 1])).to.be.equal(false)
    })
    it('should return true [-1, 2, -1]', () => {
        expect(isSymmetric([-1, 2, -1])).to.be.equal(true)
    })
    it('should return false [-1, 2, 1]', () => {
        expect(isSymmetric([-1, 2, 1])).to.be.equal(false)
    })
    it('should return false [-1, 2]', () => {
        expect(isSymmetric([-1, 2])).to.be.equal(false)
    })
    it('should return true [1]', () => {
        expect(isSymmetric([1])).to.be.equal(true)
    })
    it('should return false string', () => {
        expect(isSymmetric('string')).to.be.equal(false)
    })
    it('should return false 1, 2, 1', () => {
        expect(isSymmetric(1, 2, 1)).to.be.equal(false)
    })
    it("should return true for [5,'hi',{a:5},new Date(),{a:5},'hi',5]", function () {
        expect(isSymmetric([5,'hi',{a:5},new Date(),{a:5},'hi',5])).to.be.equal(true);
    });
    it("should return false for [5,'hi',{a:5},new Date(),{X:5},'hi',5]", function () {
        expect(isSymmetric([5,'hi',{a:5},new Date(),{X:5},'hi',5])).to.be.equal(false);
    });

});


