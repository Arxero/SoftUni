function solution(input) {
    let result = input.charCodeAt()
    if (result >= 97 && result <= 122) {
        console.log('lower-case')
    } else {
        console.log('upper-case')
    }
}
