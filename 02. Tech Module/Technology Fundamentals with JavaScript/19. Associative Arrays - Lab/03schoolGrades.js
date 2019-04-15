function solution(input) {
    let result = new Map

    for (let row of input) {
        let grades = row.split(' ')
        let name = grades.shift()
        grades = grades.map(Number)
        
        if (!result.has(name)) {
            result.set(name, grades)
        } else {
            let oldGrades = result.get(name)
            let updatedGrades = oldGrades.concat(grades)
            result.set(name, updatedGrades)
        }
    }

    let sorted = [...result].sort((a, b) => average(a, b))
    
    function average(a, b) {
        let aSum = a[1].reduce((a, b) => a + b, 0)
        let bSum = b[1].reduce((a, b) => a + b, 0)
        let aAverage = aSum / a[1].length
        let bAverage = bSum / b[1].length
        return aAverage - bAverage
    }

    for (let [key, value] of sorted) {
        console.log(`${key}: ${value.join(', ')}`)
    }
}
