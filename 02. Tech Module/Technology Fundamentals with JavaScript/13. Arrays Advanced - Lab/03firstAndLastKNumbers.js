function solution(input) {
    let k = input.shift()
    let firstKNumbers = input.slice(0, k)
    let lastKNumbers = input.reverse().slice(0, k).reverse()
    console.log(firstKNumbers.join(' '))
    console.log(lastKNumbers.join(' '))
}
