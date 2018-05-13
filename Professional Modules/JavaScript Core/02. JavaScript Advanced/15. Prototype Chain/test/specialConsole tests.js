let expect = require('chai').expect
let Console = require('../05. C# Console').Console

describe('Console', () => {
    it("should return the same string for single string argument", function () {
        expect(Console.writeLine('a')).to.be.equal('a')
    })
    it("should return stringfy object for single object argument", function () {
        expect(Console.writeLine({test: 'sajd'})).to.be.equal('{"test":"sajd"}')
    })
    it("should throw TypeError for 2 non string arguments", function () {
        expect(() => Console.writeLine(5, 6)).to.throw(TypeError)
    })
    it("should throw RangeError for more parameters than placeholders", function () {
        expect(() => Console.writeLine('{0}','one', 'two')).to.throw(RangeError)
    })
    it("should successfully replace placeholders with valid arguments", function () {
        expect(Console.writeLine('Th{0}{1}', 'i','s')).to.be.equal("This")
    })
    
    it("should recognize the placeholder numbers well", function () {
        expect(() => Console.writeLine("Not {10}", "valid")).to.throw(RangeError)
    })
})