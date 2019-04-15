function solution(input) {
    for (let i = 1; i <= input; i++) {
        let num = i
        let sum = num % 10

        while (parseInt(num / 10) > 0) {
            num = parseInt(num / 10)
            sum += num
        }

        if (sum == 5 || sum == 7 || sum == 11) {
            console.log(i + ' -> True')
        } else {
            console.log(i + ' -> False')
        }
    }
}
