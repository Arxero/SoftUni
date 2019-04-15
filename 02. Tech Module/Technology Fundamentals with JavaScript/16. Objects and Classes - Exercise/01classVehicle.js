class Vehicle {
    constructor(type, model, parts, fuel) {
        this.type = type
        this.model = model
        this._parts = parts
        this.fuel = fuel
    }

    set parts(parts) {
        this._parts = parts
    }

    get parts() {
        this._parts['quality'] = this._parts.engine * this._parts.power
        return this._parts
    }
    
    drive(fuelLoss) {
        this.fuel -= fuelLoss
    }
}
