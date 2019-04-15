function solution(n1, n2, n3) {
    let result = ''
    let numarray = [n1, n2, n3].sort((a, b) => b - a).forEach(x => {
        result += x + '\n'
    })
    console.log(result)
}
//solution(2, 1, 3)
solution(-2, 1, 3)
