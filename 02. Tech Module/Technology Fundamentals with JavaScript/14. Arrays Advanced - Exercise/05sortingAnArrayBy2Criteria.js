function solution(input) {
    let arr = input.sort(sortByLengthAndAlphabetically)

    function sortByLengthAndAlphabetically(a, b) {
        if (a.length > b.length) {
            return 1
        } else if (a.length == b.length) {
            return a.toLowerCase().localeCompare(b.toLowerCase())
        }  
    }

    console.log(arr.join('\n'))
}
//solution(["alphak", "betaaa", "gamma"])
//solution(['test', 'Deny', 'omen', 'Default'])