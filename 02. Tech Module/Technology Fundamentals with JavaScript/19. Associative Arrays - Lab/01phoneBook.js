function solution(input) {
    let result = {}

    for (let row of input) {
        row = row.split(' ')
        let name = row[0]
        let number = row[1]
        result[name] = number  
    }
    
    for (const key in result) {
        console.log(key + ' -> ' + result[key])
    }
}
