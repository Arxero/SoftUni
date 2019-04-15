function solution(input) {
    let resultArr = []
    let inputArrSum = 0
    let resultArrSum = 0

    for (let i = 0; i < input.length; i++) {
        inputArrSum += input[i]
        
        if (input[i] % 2 == 0) {
            resultArr[i] = input[i] + i
            resultArrSum += resultArr[i]
        } else {
            resultArr[i] = input[i] - i
            resultArrSum += resultArr[i]
        }
    }
    
    console.log(resultArr)
    console.log(inputArrSum)
    console.log(resultArrSum)
}
