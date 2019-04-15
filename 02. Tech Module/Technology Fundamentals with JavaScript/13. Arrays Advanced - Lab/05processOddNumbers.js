function solution(input) {
    let oddNumbers = []

    for (let i = 0; i < input.length; i++) {
        if (i % 2 != 0) {
            oddNumbers.push(input[i])
        }
    }
    console.log(oddNumbers.map(x => x * 2).reverse().join(' '))
}
