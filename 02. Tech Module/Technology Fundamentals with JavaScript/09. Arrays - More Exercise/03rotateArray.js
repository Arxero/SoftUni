function solution(input) {
    let rotations = input.pop()
    for (let i = 0; i < rotations; i++) {
        let lastElement = input.pop()
        input.unshift(lastElement)
    }
    console.log(input.join(' '))
}
