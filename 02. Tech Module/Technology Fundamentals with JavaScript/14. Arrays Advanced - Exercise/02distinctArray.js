function solution(input) {
    input = input.filter((v, i, a) => a.indexOf(v) == i)
    console.log(input.join(' '))
}
