function solution(arr, arr2) {
    let elementsToTake = arr2[0]
    let deleteCount = arr2[1]
    let numberToSearchFor = arr2[2]

    let result = arr.slice(0, elementsToTake)
    result.splice(0, deleteCount)
    let countOfOccurrence = 0
    result.forEach(x => {
        if (x == numberToSearchFor) {
            countOfOccurrence++
        }
    })

    console.log(`Number ${numberToSearchFor} occurs ${countOfOccurrence} time.`)
}
