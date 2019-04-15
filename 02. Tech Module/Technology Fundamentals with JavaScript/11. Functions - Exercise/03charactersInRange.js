function solution(a, b) {
    console.log(printChars(a, b))

    function printChars(a, b) {
        let start = Math.min(a.charCodeAt(), b.charCodeAt())
        let end = Math.max(a.charCodeAt(), b.charCodeAt())
        let arrayOfChars = []

        for (let i = start + 1; i < end; i++) {
            arrayOfChars.push(String.fromCharCode(i))
        }
        return arrayOfChars.join(' ')
    }
}
