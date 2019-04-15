function solution(arr, arr2) {
    let result = []
    for (let i = 0; i < arr.length; i++) {
        if (i % 2 == 0) {
            result[i] = +arr[i] + +arr2[i]
        } else {
            result[i] = arr[i] + arr2[i]
        }
    }
    console.log(result.join(' - '))
}
