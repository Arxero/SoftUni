class PaymentProcessor {
    constructor(...options) {
        if (options.length > 0) {
            this.options = options[0]
        } else {
            this.options = {}
        }
        this.payments = []
    }

    get options() {
        return this._options
    }

    set options(op) {
        if (this._options == undefined) {
            this._options = {}
        }
        if (this._options.types == undefined) {
            this._options.types = ["service", "product", "other"]
        }
        if (this._options.precision == undefined) {
            this._options.precision = 2
        }
        if (op.hasOwnProperty('precision')) {
            if (op.precision != undefined) {
                this._options.precision = op.precision
            }
        }
        if (op.hasOwnProperty('types')) {
            if (op.types != undefined) {
                this._options.types = op.types
            }
        }
    }

    setOptions(o){
        this.options = o
    }

    registerPayment(id, name, type, value) {
        if (id.length > 0 && typeof id == 'string' && name.length > 0 && typeof name == 'string' && typeof value == 'number' && this.payments.filter(x => id == x.id).length == 0 && this.options.types.includes(type)) {
            this.payments.push({ id, name, type, value })
        } else {
            throw Error
        }
    }

    deletePayment(id) {
        if (this.payments.filter(x => id == x.id).length == 0) {
            throw Error
        }
        this.payments = this.payments.filter(x => id != x.id)
    }

    get(id) {
        if (this.payments.filter(x => id == x.id).length == 0) {
            throw Error
        }
        let payment = this.payments.filter(x => id == x.id)
        return `
        Details about payment ID: ${id}
        - Name: ${payment[0].name}
        - Type: ${payment[0].type}
        - Value: ${payment[0].value.toFixed(this.options.precision)}`

    }

    toString() {
        let balance = 0
        return `
        Summary:
        - Payments: ${this.payments.length}
        - Balance: ${this.payments.map(x => balance += x.value).reverse()[0].toFixed(this.options.precision)}`
    }

}

// Initialize processor with default options
// const generalPayments = new PaymentProcessor();
// generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
// generalPayments.registerPayment('01A3', 'Biopolymer', 'product', 23000);
// console.log(generalPayments.toString());
// // Should throw an error (invalid type)
// generalPayments.registerPayment('E028', 'Rare-earth elements', 'materials', 8000);
// generalPayments.setOptions({types: ['product', 'material']});
// generalPayments.registerPayment('E028', 'Rare-earth elements', 'material', 8000);
//console.log(generalPayments.get('0001'));
//console.log(generalPayments.deletePayment('0002'));
// generalPayments.registerPayment('CF15', 'Enzymes', 'material', 55000);
// // Should throw an error (ID not found)
// generalPayments.deletePayment('E027');
// // Should throw an error (ID not found)
// generalPayments.get('E027');
// generalPayments.deletePayment('E028');
// console.log(generalPayments.toString());
// // Initialize processor with custom types
// const servicePyaments = new PaymentProcessor({types: ['service']});
// servicePyaments.registerPayment('01', 'HR Consultation', 'service', 3000);
// servicePyaments.registerPayment('02', 'Discount', 'service', -1500);
// console.log(servicePyaments.toString());
// // Initialize processor with custom precision
// const transactionLog = new PaymentProcessor({precision: 5});
// transactionLog.registerPayment('b5af2d02-327e-4cbf', 'Interest', 'other', 0.00153);
// console.log(transactionLog.toString());
