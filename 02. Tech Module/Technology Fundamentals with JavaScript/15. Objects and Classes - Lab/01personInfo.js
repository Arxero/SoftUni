function solution(firstName, lastName, age) {
    let result = {
        'firstName' : firstName,
        'lastName' : lastName,
        'age' : age
    }

    let entries = Object.entries(result)

    for (let [key, value] of entries) {
        console.log(key + ': ' + value)
    }
}
