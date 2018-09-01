class Ticket {
    destination: string
    price: number
    status: string
    tickets: string[]
    sortingCriteria: string

    constructor(tickets: string[], sortingCriteria: string) {
        this.tickets = tickets
        this.sortingCriteria = sortingCriteria
    }

    getTickets = () => {
        let arr = []
        let ticketsArray = this.tickets.map(t => t.split('|'))
        ticketsArray.forEach(element => {
            let obj = {}
            obj['destination'] = element[0]
            obj['price'] = Number(element[1])
            obj['status'] = element[2]
            arr.push({ Ticket: obj })
        })

        switch (this.sortingCriteria) {
            case 'destination':
                arr.sort((a, b) => a.Ticket.destination.localeCompare(b.Ticket.destination))
                break;
            case 'price':
                arr.sort((a, b) => a.Ticket.price - b.Ticket.price)
                break;
            case 'status':
                arr.sort((a, b) => a.Ticket.status.localeCompare(b.Ticket.status))
                break;
        }

        return arr
    }


}

let tickets = new Ticket(
    ['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination'
)

let tickets2 = new Ticket(
    ['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'status'
)

console.log('First Tickets:')
console.log(tickets.getTickets())
console.log('Second Tickets:')
console.log(tickets2.getTickets())
