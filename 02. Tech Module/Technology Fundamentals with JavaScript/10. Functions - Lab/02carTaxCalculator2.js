function solution(power, age) {
    let powerCalculated = calculatePower(+power)
    let ageCalculated = calculateAge(+age)
    let result = powerCalculated * ageCalculated
    console.log(result.toFixed(2) + ' lv.')

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
