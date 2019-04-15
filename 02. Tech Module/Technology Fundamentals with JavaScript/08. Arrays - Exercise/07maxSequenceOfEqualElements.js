function solution(input) {
    input = input[0].split(' ').map(n => +n)
    let longestSequenceLength = 0
    let longestSequenceNumber = 0
    let currentSequenceLength = 0
    let currentSequenceNumber = 0

    for (let i = 0; i < input.length; i++) {
        if (i == 0) {
            currentSequenceLength = 1
            longestSequenceLength = 1
            longestSequenceNumber = input[i]
            currentSequenceNumber = input[i]

        } else if (currentSequenceNumber != input[i]) {
            currentSequenceLength = 1
            currentSequenceNumber = input[i]

        } else if (currentSequenceNumber == input[i]) {
            currentSequenceLength++
            
            if (currentSequenceLength > longestSequenceLength) {
                longestSequenceLength = currentSequenceLength
                longestSequenceNumber = currentSequenceNumber
            }
        }
    }

    let result = ''
    for (let i = 0; i < longestSequenceLength; i++) {
        result += longestSequenceNumber + ' '
    }
    console.log(result)
}
