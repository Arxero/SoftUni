function solution(input) {
    let indexWithEqualSums = -1

    for (let i = 0; i < input.length; i++) {
        let sumLeft = 0
        let sumRight = 0

        for (let k = i + 1; k < input.length; k++) {
            sumRight += input[k]
        }

        for (let j = i - 1; j >= 0; j--) {
            sumLeft += input[j]
        }

        if (sumLeft == sumRight) {
            indexWithEqualSums = i
        }
    }

    if (indexWithEqualSums > -1) {
        console.log(indexWithEqualSums)
    } else {
        console.log('no')
    }
}
