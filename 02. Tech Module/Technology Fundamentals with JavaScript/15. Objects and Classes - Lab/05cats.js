function solution(input) {
    let cats = []

    class Cat {
        constructor(name, age) {
            this.name = name
            this.age = age
        }

        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`)
        }
    }

    for (let i = 0; i < input.length; i++) {
        let catsData = input[i].split(' ')
        let name = catsData[0]
        let age = catsData[1]
        cats.push(new Cat(name, age))
    }

    for (let cat of cats) {
        cat.meow()
    }
}
