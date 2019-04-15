function solution(input) {
    let budget = +input[0]
    let students = +input[1]
    let flour = +input[2]
    let egg = +input[3] * 10
    let apron = +input[4]

    let price = 0
    for (let i = 1; i <= students; i++) {
        price += flour + egg

        if (i % 5 == 0) {
            price -= flour
        }
    }

    apron = apron * Math.ceil(students + (students * 20 / 100))
    price += apron

    if (budget >= price) {
        console.log(`Items purchased for ${price.toFixed(2)}$.`)
    } else {
        console.log(`${(price - budget).toFixed(2)}$ more needed.`)
    }
}

