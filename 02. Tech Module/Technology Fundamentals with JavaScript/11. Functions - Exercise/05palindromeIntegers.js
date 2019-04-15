function solution(input) {
    for (let i = 0; i < input.length; i++) {
        let currentN = input[i].toString()
        let reversedCurrentN = currentN.toString().split('').reverse().join('')
        if (currentN == reversedCurrentN) {
            console.log(true)
        } else {
            console.log(false)
        }
    }
}
