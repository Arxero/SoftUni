function solution(name, area, population, country, postCode) {
    let cityObject = {
        name,
        area,
        population,
        country,
        postCode
    }

    let result = Object.entries(cityObject)
    for (let [key, value] of result) {
        console.log(key + ' -> ' + value)
    }
}
