function solution(input) {
    if (validateLength(input) == true && validateContent(input) == true && validateTwoDigits(input) == true) {
        console.log('Password is valid ')
    } else {
        if (validateLength(input) != true) {
            console.log(validateLength(input))
        }
        if (validateContent(input) != true) {
            console.log(validateContent(input))
        }
        if (validateTwoDigits(input) != true) {
            console.log(validateTwoDigits(input))
        }
    }


    function validateLength(input) {
        if (input.length >= 6 && input.length <= 10) {
            return true
        }
        return 'Password must be between 6 and 10 characters'
    }

    function validateContent(input) {
        input = input.split('')
        for (let char of input) {
            let toChar = char.charCodeAt()
            if ((toChar >= 48 && toChar <= 57) ||
                (toChar >= 65 && toChar <= 90) ||
                (toChar >= 97 && toChar <= 122)) {
            } else {
                return 'Password must consist only of letters and digits'
            }
        }
        return true
    }

    function validateTwoDigits(input) {
        let countOfDigits = 0
        input = input.split('').forEach(x => {
            if (!isNaN(+x)) {
                countOfDigits++
            }
        })
        if (countOfDigits >= 2) {
            return true
        } else {
            return 'Password must have at least 2 digits'
        }
    }
}
