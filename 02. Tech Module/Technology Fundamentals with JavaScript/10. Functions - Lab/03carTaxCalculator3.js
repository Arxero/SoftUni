function solution(type, power, age) {

    switch (type) {
        case 'motorcycle':
            totalCaclMotorcycle(power)
            break;
        case 'car':
            let result = totalCalcCar(calculatePower(+power), calculateAge(age))
            console.log(result)
            break;
    }

    function totalCaclMotorcycle(volume) {
        let taxPrice = 0
        if (volume > 750) {
            taxPrice = 125
        } else if (volume > 490) {
            taxPrice = 94
        } else if (volume > 350) {
            taxPrice = 63
        } else if (volume > 250) {
            taxPrice = 44
        } else if (volume > 125) {
            taxPrice = 31
        } else {
            taxPrice = 15
        }

        taxPrice = taxPrice.toFixed(2)
        console.log(taxPrice + ' lv.')
    }

    function totalCalcCar(power, age) {
        let totalPrice = power * age
        totalPrice = totalPrice.toFixed(2) + ' lv.'
        return totalPrice
    }

    function calculatePower(power) {
        if (power <= 37) {
            return power * .43
        } else if (power >= 37.01 && power <= 55) {
            return power * .5
        } else if (power >= 55.01 && power <= 74) {
            return power * .68
        } else if (power >= 74.01 && power <= 110) {
            return power * 1.38
        } else if (power > 110) {
            return power * 1.54
        }
    }

    function calculateAge(age) {
        if (age < 5) {
            return 2.8
        } else if (age >= 5 & age <= 14) {
            return 1.5
        } else if (age > 14) {
            return 1
        }
    }
}
//solution('car', '90', '7')
solution('motorcycle', '450', '10')