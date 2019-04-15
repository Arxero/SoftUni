function solution(input) {
    let sum = +input.pop()
    input = input[0].split(' ').map(n => +n)
    
    for (let i = 0; i < input.length; i++) {
        let currentN = input[i]

        for (let j = i + 1; j < input.length; j++) {
            let everyOtherN = input[j]

            if (currentN + everyOtherN == sum) {
                console.log(currentN + ' ' + everyOtherN)
            }
        }
    }
}
