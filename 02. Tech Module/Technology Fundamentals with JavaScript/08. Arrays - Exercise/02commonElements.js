function solution(arr, arr2) {
    //checking which array is longer and starting from it
    if (arr.length >= arr2.length) {
        for (let i = 0; i < arr.length; i++) {
            if (arr2.includes(arr[i])) {
                console.log(arr[i])
            }
        }
    } else {
        for (let i = 0; i < arr2.length; i++) {
            if (arr.includes(arr2[i])) {
                console.log(arr[i])
            }
        }
    }
}
