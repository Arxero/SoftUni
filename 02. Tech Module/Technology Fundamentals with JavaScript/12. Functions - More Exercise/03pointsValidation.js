function solution(input) {
    let x0 = 0
    let y0 = 0
    let x1 = input[0]
    let y1 = input[1]
    let x2 = input[2]
    let y2 = input[3]

    let distanceP1And0 = Math.sqrt(Math.pow(x1 - x0, 2) + Math.pow(y1 - y0, 2))
    let distanceP2And0 = Math.sqrt(Math.pow(x2 - x0, 2) + Math.pow(y2 - y0, 2))
    let distanceP1AndP2 = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2))

    function printResult(distance, x1, y1, x2, y2) {
        if (Number.isInteger(distance)) {
            return `{${x1}, ${y1}} to {${x2}, ${y2}} is valid`
        }
        return `{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`
    }

    console.log(printResult(distanceP1And0, x1, y1, x0, y0))
    console.log(printResult(distanceP2And0, x2, y2, x0, y0))
    console.log(printResult(distanceP1AndP2, x1, y1, x2, y2))
}
