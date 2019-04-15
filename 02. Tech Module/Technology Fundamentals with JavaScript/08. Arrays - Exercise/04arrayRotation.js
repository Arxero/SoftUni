function solution(input, n) {
    for (let i = 0; i < n; i++) {
        input[input.length] = input[i]
    }

    for (let i = 0; i < n; i++) {
        input.shift()
    }

    console.log(input.join(' '))
}
