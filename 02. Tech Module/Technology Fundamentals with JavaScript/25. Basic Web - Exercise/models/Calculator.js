class Calculator {
    constructor(leftOperand, operator, rightOperand) {
        this.leftOperand = leftOperand
        this.operator = operator
        this.rightOperand = rightOperand
    }

    calculateResult() {
        let result = 0

        switch (this.operator) {
            case '+':
                result = +this.leftOperand + +this.rightOperand
                break;
            case '-':
                result = this.leftOperand - this.rightOperand
                break;
            case '*':
                result = this.leftOperand * this.rightOperand
                break;
            case '/':
                result = this.leftOperand / this.rightOperand
                break;
        }
        return result
    }
}

module.exports = Calculator