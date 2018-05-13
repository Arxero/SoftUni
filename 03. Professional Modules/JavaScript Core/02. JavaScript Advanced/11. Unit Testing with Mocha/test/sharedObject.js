let expect = require('chai').expect
let sharedObject = require('../shared-object.js').sharedObject
let jsdom = require('jsdom-global')()
let $ = require('jquery')

document.body.innerHTML = `<div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`

describe('sharedObject', () => {
    before(() => global.$ = $);

    describe('changeName', () => {
        it('should return previous name for empty string parameter', () => {
            sharedObject.changeName('Mav')
            sharedObject.changeName('')
            expect(sharedObject.name).to.be.equal('Mav')
            expect($('#name').val()).to.be.equal('Mav')
        })
    })

    describe('changeIncome', () => {
        it('should return previous value after calling with 0 parameter', () => {
            sharedObject.changeIncome(5)
            sharedObject.changeIncome(0)
            expect(sharedObject.income).to.be.equal(5)
            expect($('#income').val()).to.be.equal('5')
        })
        it('should return previous value after calling with negative parameter', () => {
            sharedObject.changeIncome(5)
            sharedObject.changeIncome(-10)
            expect(sharedObject.income).to.be.equal(5)
            expect($('#income').val()).to.be.equal('5')
        })
    })

    describe('updateName', () => {
        it('should successfully change name with non empty string', () => {
            sharedObject.changeName('oldName')
            $("#name").val("newName")
            sharedObject.updateName()
            expect(sharedObject.name).to.be.equal('newName')
            expect($('#name').val()).to.be.equal('newName')
        })
        it('should not change name with empty string', () => {
            sharedObject.changeName('oldName')
            $("#name").val("");
            sharedObject.updateName()
            expect(sharedObject.name).to.be.equal('oldName')
            expect($('#name').val()).to.be.equal('')
        })
    })

    describe("updateIncome function", function () {
        it("should return previous value if value is negative number or float", function () {
            sharedObject.changeIncome(2)
            $("#income").val("-2.5")
            sharedObject.updateIncome()
            expect(sharedObject.income).to.equal(2)
            expect($("#income").val()).to.equal("-2.5")
        })
        it("should return previous value if value is 0", function () {
            sharedObject.changeIncome(2)
            $("#income").val("0");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(2)
            expect($("#income").val()).to.equal("0")
        })
        it("should return correct value id value is positive integer", function () {
            sharedObject.changeIncome(2);
            $("#income").val("3");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(3)
            expect($("#income").val()).to.equal("3")
        })
    })
})