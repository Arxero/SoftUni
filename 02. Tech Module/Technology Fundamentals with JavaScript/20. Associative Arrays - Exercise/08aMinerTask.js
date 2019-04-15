function solution(input) {
    let result = {}

    for (let i = 0; i < input.length; i += 2) {
        let resource = input[i]
        let quantity = +input[i + 1]
        
        if (!result.hasOwnProperty(resource)) {
            result[resource] = quantity
        } else {
            result[resource] += quantity
        }
    }

    Object.entries(result).forEach(x => console.log(x[0] + ' -> ' + x[1]))
}
