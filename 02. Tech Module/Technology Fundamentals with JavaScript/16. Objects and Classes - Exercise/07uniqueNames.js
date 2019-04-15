function solution(input) {
    input = input.filter((v, i, a) => a.indexOf(v) == i)
    console.log(input.sort(sortyBylenghtAndAphabetically).join('\n'))

    function sortyBylenghtAndAphabetically(a, b) {
        if (a.length > b.length) {
            return 1
        } else if (a.length == b.length) {
            return a.toLowerCase().localeCompare(b.toLowerCase())
        } else {
            return -1
        }
    }
}
