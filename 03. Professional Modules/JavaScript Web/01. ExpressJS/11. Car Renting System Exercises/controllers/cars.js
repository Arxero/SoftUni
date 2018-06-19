const Car = require('../models/Car')
const User = require('../models/User')
const seedCars = require('../database/carsdb')

module.exports.viewAll = (req, res) => {
    
    Car.find({ isItRented: false }).then(cars => {
        if (cars.length == 0) {
            Car.create(seedCars).then(cars => {
                renderCars(cars)
            })
        } else {
            renderCars(cars)
        }
    })

    function renderCars(cars) {
        let queryData = req.query
        if (queryData.query) {
            cars = cars.filter(x => x.make.toLowerCase().includes(queryData.query))
        }
        let content = ''
        for (let car of cars.sort((a, b) => a.make > b.make)) {
            content += `
                    <div class="car-container">
                    <section>
                        <a href="/cars/edit/${car._id}">
                            <img src="${car.imageUrl}" alt='car-image' />    
                        </a>           
                    </section>
                    <section class="info">
                        <strong>${car.make}</strong>
                        <span class="rented">rented: 
                            <strong>${car.rentedCount}</strong>
                        </span>
                    </section>
                </div>`
        }
        let data = {}
        if (req.query.error) {
            data.error = req.query.error
        } else if (req.query.success) {
            data.success = req.query.success
        }

        res.render('cars/all', { content, data })
    }
}

module.exports.addCarGet = (req, res) => {
    res.render('cars/create')
}

module.exports.addCarPost = (req, res) => {
    let car = req.body
    car.imageUrl = '\\' + req.file.path
    Car.create(car).then(car => {
        res.redirect('/cars/all?success=' + encodeURIComponent('Car added successfully!'))
    })
}

module.exports.editCarGet = (req, res) => {
    let id = req.params.id
    Car.findById(id).then(car => {
        res.render('cars/edit', { car })
    })
}

module.exports.editCarPost = (req, res) => {
    let id = req.params.id
    let editedCar = req.body

    Car.findById(id).then(car => {
        if (!car) {
            res.redirect(`/?error=${encodeURIComponent('error=Car was not found!')}`)
            return
        }

        car.make = editedCar.make
        car.model = editedCar.model
        car.color = editedCar.color
        //car.imageUrl = editedCar.imageUrl
        car.dailyPrice = editedCar.dailyPrice
        if (req.file) {
            car.imageUrl = '\\' + req.file.path
        }

        car.save().then(() => {
            res.redirect('/cars/all?success=' + encodeURIComponent('Car was edited successfully!'))
        })
    })
}

module.exports.rentCarGet = (req, res) => {
    let id = req.params.id
    Car.findById(id).then(car => {
        res.render('cars/rent', { car })
    })
}

module.exports.rentCarPost = (req, res) => {
    let userId = req.session.passport.user
    let carId = req.params.id
    let carToRent = req.body
    
    User.findById(userId).then(user => {
        Car.findById(carId).then(car => {
            let rented = {
                id: carId,
                duration: carToRent.rentDays,
                make: car.make,
                model: car.model
            }
            user.rentedCars.push(rented)
            car.rentedCount += 1
            car.isItRented = true
            user.save().then(() => {
                car.save().then(() => {
                    res.redirect('/?success=' + encodeURIComponent('Car was Rented successfully!'))
                    return
                })
            })
        })
    })
}