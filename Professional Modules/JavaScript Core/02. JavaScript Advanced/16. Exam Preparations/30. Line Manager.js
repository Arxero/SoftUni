class LineManager {
    constructor(stops) {
        this.stops = stops
    }

    get stops() {
        return this._stops
    }

    set stops(stops) {
        this._stops = []
        for (let stop of stops) {
            if (typeof stop.name == 'string' && stop.name.length > 0 && typeof stop.timeToNext == 'number' && stop.timeToNext >= 0) {
                this._stops.push(stop)
            } else {
                throw Error
            }
        }
    }

    get atDepot() {
        return false
    }

    get nextStopName() {

    }

    get currentDelay() {

    }

    arriveAtStop(minutes) {
        if (typeof minutes != 'number' || minutes < 0) {
            throw Error
        }else {
            return true
        }
    }

    toString() {
        return `
        
        `
    }
}

// Initialize a line manager with correct values
const man = new LineManager([
    { name: 'Depot', timeToNext: 4 },
    { name: 'Romanian Embassy', timeToNext: 2 },
    { name: 'TV Tower', timeToNext: 3 },
    { name: 'Interpred', timeToNext: 4 },
    { name: 'Dianabad', timeToNext: 2 },
    { name: 'Depot', timeToNext: 0 },
]);

// // Travel through all the stops until the bus is at depot
// while (man.atDepot === false) {
//     console.log(man.toString());
//     man.arriveAtStop(4);
// }
// console.log(man.toString());
// // Should throw an Error (minutes cannot be negative)
//man.arriveAtStop(-4);
// Should throw an Error (last stop reached)
// man.arriveAtStop(4);
// // Should throw an Error at initialization
// const wrong = new LineManager([
//     { name: 'Stop', timeToNext: { wrong: 'Should be a number' } }
// ]);


//console.log(man);

