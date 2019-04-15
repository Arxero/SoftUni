function solution(input) {
    let result = []

    for (let i = 0; i < input.length; i++) {
        let indexOfLvl = input[i].indexOf('/')
        let name = input[i].slice(0, indexOfLvl).trim()
        let lvlInStart = input[i].substr(indexOfLvl + 2)
        let secondIndexOfLvl = lvlInStart.indexOf('/')
        let level = +lvlInStart.slice(0, secondIndexOfLvl).trim()
        let items = lvlInStart.slice(secondIndexOfLvl + 2).split(', ')
        
        let obj = {name, level, items}
        result.push(obj)
    }
    console.log(JSON.stringify(result))
}
