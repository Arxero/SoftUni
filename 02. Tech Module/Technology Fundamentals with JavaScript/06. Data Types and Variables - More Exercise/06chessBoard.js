function solution(input) {
    let result = '<div class="chessboard">' + '\n'
    for (let i = 0; i < input; i++) {
        result += '  <div>' + '\n'

        if (i % 2 == 0) {
            for (let k = 0; k < input; k++) {
                if (k % 2 == 0) {
                    result += '    <span class="black"></span>' + '\n'
                } else {
                    result += '    <span class="white"></span>' + '\n'
                }
            }
        } else {
            for (let k = 0; k < input; k++) {
                if (k % 2 == 0) {
                    result += '    <span class="white"></span>' + '\n'
                } else {
                    result += '    <span class="black"></span>' + '\n'
                }
            }
        }

        result += '   </div>' + '\n'
    }

    result += '</div>'
    console.log(result)
}
