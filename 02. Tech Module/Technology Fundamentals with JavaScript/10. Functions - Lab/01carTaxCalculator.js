function solution(input) {
    console.log(calculate(+input).toFixed(2) + ' lv.')

    function calculate(input) {
        if (input <= 37) {
            return input * .43
        } else if (input >= 37.01 && input <= 55) {
            return input * .5
        } else if (input >= 55.01 && input <= 74) {
            return input * .68
        } else if (input >= 74.01 && input <= 110) {
            return input * 1.38
        } else if (input > 110) {
            return input * 1.54
        }
    }
}
