function solution(input) {
    let username = input[0]
    let usernameReversed = username.split('').reverse().join('')
    for (let i = 1; i < input.length; i++) {
        if (usernameReversed == input[i] && i <= 4) {
            console.log(`User ${username} logged in.`)
        }  else if (usernameReversed != input[i] && i < 4) {
            console.log('Incorrect password. Try again.')
        }  else {
            console.log(`User ${username} blocked!`)
            return
        }
    }
}
