function solution(arr, string) {
    let arrSplited = []
    for (let row of arr) {
        let ticket = row.split('|')
        arrSplited.push(ticket)
    }

    let sortedTckets = [];
    switch (string) {
        case "destination":
            sortedTckets = arrSplited.sort((a, b) => a[0].localeCompare(b[0]));
            break;
        case "price":
            sortedTckets = arrSplited.sort((a, b) => Number(a[1]) - Number(b[1]));
            break;
        case "status":
            sortedTckets = arrSplited.sort((a, b) => a[2].localeCompare(b[2]));
            break;
    }

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination
            this.price = price
            this.status = status
        }
    }

    let result = []
    for (let row of sortedTckets) {
        result.push(new Ticket(row[0], Number(row[1]), row[2]))
    }
    return result
    
}

// solution(
//     ['Philadelphia|94.20|available',
//         'New York City|95.99|available',
//         'New York City|95.99|sold',
//         'Boston|126.20|departed'],
//     'destination'
// )

// solution(
//     ['Philadelphia|94.20|available',
//         'New York City|95.99|available',
//         'New York City|95.99|sold',
//         'Boston|126.20|departed'],
//     'status'
// )