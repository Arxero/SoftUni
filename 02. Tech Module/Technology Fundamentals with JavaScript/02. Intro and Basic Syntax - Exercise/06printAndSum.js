function solution(start, end) {
    let iAppended = ''
    let sum = 0
    for (let i = start; i <= end; i++) {
        sum += i
        iAppended += i + ' '  
    }
    console.log(iAppended)
    console.log('Sum: ' + sum)
}
