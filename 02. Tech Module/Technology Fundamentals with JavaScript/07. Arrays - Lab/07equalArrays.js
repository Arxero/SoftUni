function solution(array, array2) {
    let sum = 0
    for (let i = 0; i < array.length; i++) {
        if (array[i] == array2[i]) {
            sum += +array[i]
        } else {
            console.log(`Arrays are not identical. Found difference at ${i} index`)
            return
        }
    }
    console.log('Arrays are identical. Sum: ' + sum)
}
