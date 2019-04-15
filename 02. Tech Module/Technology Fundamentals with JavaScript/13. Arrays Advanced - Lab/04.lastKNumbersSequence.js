function solution(n, k) {
    let result = [1]
    let startIndex = 0

    for (let i = 0; i < n - 1; i++) {
        let spliceArr = []
        //copying result array to splice arr
        result.map(x => spliceArr.push(x))
        //making sure that we start at the correct index when there is enough elements
        if (i >= k) {
            startIndex++
        }

        let lastKNumbers = spliceArr.splice(startIndex, k)
        let sum = 0
        lastKNumbers.map(x => sum += x)
        result.push(sum)
    }

    console.log(result.join(' '))
}
