function solution(input) {
    let result = {}

    for (let row of input) {
        let [company, userId] = row.split(' -> ')

        if (!result.hasOwnProperty(company)) {
            let users = []
            users.push(userId)
            result[company] = users
        } else {
            let oldUsers = result[company]
            if (!oldUsers.includes(userId)) {
                oldUsers.push(userId)
                result[company] = oldUsers
            }
        }
    }

    let sorted = Object.entries(result).sort((a, b) => a[0].localeCompare(b[0]))
    sorted.forEach(x => {
        console.log(x[0])
        x[1].forEach(x => console.log('-- ' + x))
    })
}
