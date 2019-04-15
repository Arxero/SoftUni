function solution(input) {
    let initialFlights = input[0]
    let flights = []

    for (let row of initialFlights) {
        row = row.split(' ')
        let sector = row[0]
        let destination = row[1]
        let currentFlight = {
            sector,
            destination,
            status: 'Ready to fly'
        }
        flights.push(currentFlight)
    }

    let statuses = input[1]
    for (let row of statuses) {
        row = row.split(' ')
        let statusesSector = row[0]
        let statusesStatus = row[1]

        for (let flight of flights) {
            if (statusesSector == flight.sector) {
                flight.status = statusesStatus
            }
        }
    }

    let flightStatus = input[2]
    for (let row of flights) {
        if (row.status == flightStatus) {
            console.log(`{ Destination: '${row.destination}', Status: '${row.status}' }`)
        }
    }
}
