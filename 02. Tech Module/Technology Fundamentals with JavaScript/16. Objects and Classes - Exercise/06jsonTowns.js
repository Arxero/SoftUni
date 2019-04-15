function solution(input) {
    let result = []
    input.shift()
    
    for (let row of input) {
        row = row.split(' ').filter(x => x != '|')
        let latitude = +row[1]
        let longitude = +row[2]
        let obj = {
            'Town' : row[0],
            'Latitude' : +latitude.toFixed(2),
            'Longitude' : +longitude.toFixed(2),
        }
        result.push(obj)
    }
    console.log(JSON.stringify(result))
}
