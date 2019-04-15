function solution(input) {
    let people = []

    for (let row of input) {
        row = row.split(' ')
        let person = row[0]

        if (row.length == 3) {
            if (!people.includes(person)) {
                people.push(person)
            } else {
                console.log(person + ' is already in the list!')
            }
        } else {
            if (!people.includes(person)) {
                console.log(person + ' is not in the list!')
            } else {
                let indexOfPerson = people.indexOf(person)
                people.splice(indexOfPerson, 1)
            }
        }
    }

    console.log(people.join('\n'))
}
