function createComputerHierarchy() {
    class Keyboard {
        constructor(manufacturer, responseTime) {
            this.manufacturer = manufacturer
            this.responseTime = responseTime
        }
    }

    class Monitor {
        constructor(manufacturer, width, height) {
            this.manufacturer = manufacturer
            this.width = width
            this.height = height
        }
    }

    class Battery {
        constructor(manufacturer, expectedLife) {
            this.manufacturer = manufacturer
            this.expectedLife = expectedLife
        }
    }

    class Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace) {
            if (new.target == Computer) {
                throw new Error('Abstract class cannot be instantiated directly')
            }
            this.manufacturer = manufacturer
            this.processorSpeed = processorSpeed
            this.ram = ram
            this.hardDiskSpace = hardDiskSpace
            
        }
    }

    class Laptop extends Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace, weight, color, battery) {
            super(manufacturer, processorSpeed, ram, hardDiskSpace)
            this.weight = weight
            this.color = color
            this.battery = battery
        }
        set battery(b){
            if (!(b instanceof Battery)) {
                throw new TypeError('Not a valid battery')
            }
            this._battery = b
        }
        get battery(){
            return this._battery
        }
    }

    class Desktop extends Computer {
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace, keyboard, monitor) {
            super(manufacturer, processorSpeed, ram, hardDiskSpace)
            this.keyboard = keyboard
            this.monitor = monitor
        }
        set keyboard(k){
            if (!(k instanceof Keyboard)) {
                throw new TypeError('Not a valid keyboard')
            }
            this._keyboard = k
        }
        get keyboard(){
            return this._keyboard
        }

        set monitor(m){
            if (!(m instanceof Monitor)) {
                throw new TypeError('Not a valid monitor')
            }
            this._monitor = m
        }
        get monitor(){
            return this._monitor
        }
    }


    return {
        Keyboard,
        Monitor,
        Battery,
        Computer,
        Laptop,
        Desktop
    }

}