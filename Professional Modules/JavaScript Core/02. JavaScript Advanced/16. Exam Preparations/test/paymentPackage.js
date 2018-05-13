let expect = require('chai').expect
let PaymentPackage = require('../26. Payment Package')

describe('PaymentPackage', () => {
    it('shoud have own properties', () => {
        let p = new PaymentPackage("testP", 50);
        expect(p.hasOwnProperty("_name")).to.be.true;
        expect(p.hasOwnProperty("_value")).to.be.true;
        expect(p.hasOwnProperty("_VAT")).to.be.true;
        expect(p.hasOwnProperty("_active")).to.be.true;
    });

    it('should be able to be instantied with two parameters, string and value', () => {
        let package = new PaymentPackage('HR Services', 1500.987)
        expect(package.active = false).to.be.equal(false)
        expect(package.toString()).to.be.equal(`Package: ${package.name} (inactive)\n- Value (excl. VAT): ${package.value}\n- Value (VAT ${package.VAT}%): ${package.value * (1 + package.VAT / 100)}`)
        let package2 = new PaymentPackage('HR Services', 0)
        expect(package2.active = false).to.be.equal(false)
        expect(package2.toString()).to.be.equal(`Package: ${package2.name} (inactive)\n- Value (excl. VAT): ${package2.value}\n- Value (VAT ${package2.VAT}%): ${package2.value * (1 + package2.VAT / 100)}`)
    });
});