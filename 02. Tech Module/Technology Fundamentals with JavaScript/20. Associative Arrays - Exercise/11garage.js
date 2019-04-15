function solution(input) {
    let result = {}

    for (let row of input) {
        let [garage, car] = row.split(' - ')
        let carProperties = []

        car.split(', ').forEach(x => {
            x = x.replace(': ', ' - ')
            carProperties.push(x)
        })

        if (!result.hasOwnProperty(garage)) {
            result[garage] = [carProperties]
        } else {
            result[garage].push(carProperties)
        }
    }

    Object.entries(result).sort((a, b) => b[1].length - a[1].length).forEach(x => {
        console.log('Garage № ' + x[0])
        x[1].forEach(x => console.log('--- ' + x.join(', ')))
    })
}
solution(['1 - color: blue, fuel type: diesel', '1 - color: red, manufacture: Audi', '4 - fuel type: petrol', '2 - color: dark blue, fuel type: diesel, manufacture: Fiat'])