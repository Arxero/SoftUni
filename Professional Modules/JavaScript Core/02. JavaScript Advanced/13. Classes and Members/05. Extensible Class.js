(function () {
    let counter = 0
    return class Extensible {
        constructor() {
            this.id = counter
            counter++
        }
        extend(template) {
            for (let row of Object.keys(template)) {
                if (typeof(template)[row] == 'function') {
                    Object.getPrototypeOf(this)[row] = template[row]
                    
                }else {
                    this[row] = template[row]
                }
            }
        }
    }
})()