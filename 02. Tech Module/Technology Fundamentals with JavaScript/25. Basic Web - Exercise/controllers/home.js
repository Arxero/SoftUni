let Calculator = require('../models/Calculator')

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let leftOperand = req.body.calculator.leftOperand
        let operator = req.body.calculator.operator
        let rightOperand = req.body.calculator.rightOperand
        let calculator = new Calculator(leftOperand, operator, rightOperand)
        let result = calculator.calculateResult()
        res.render('home/index', {'calculator': calculator, 'result' : result})
    }
};