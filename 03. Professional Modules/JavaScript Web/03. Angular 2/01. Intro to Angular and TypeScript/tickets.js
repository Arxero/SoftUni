var Ticket = /** @class */ (function () {
    function Ticket(tickets, sortingCriteria) {
        var _this = this;
        this.getTickets = function () {
            var arr = [];
            var ticketsArray = _this.tickets.map(function (t) { return t.split('|'); });
            ticketsArray.forEach(function (element) {
                var obj = {};
                obj['destination'] = element[0];
                obj['price'] = Number(element[1]);
                obj['status'] = element[2];
                arr.push({ Ticket: obj });
            });
            switch (_this.sortingCriteria) {
                case 'destination':
                    arr.sort(function (a, b) { return a.Ticket.destination.localeCompare(b.Ticket.destination); });
                    break;
                case 'price':
                    arr.sort(function (a, b) { return a.Ticket.price - b.Ticket.price; });
                    break;
                case 'status':
                    arr.sort(function (a, b) { return a.Ticket.status.localeCompare(b.Ticket.status); });
                    break;
            }
            return arr;
        };
        this.tickets = tickets;
        this.sortingCriteria = sortingCriteria;
    }
    return Ticket;
}());
var tickets = new Ticket(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'], 'destination');
var tickets2 = new Ticket(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'], 'status');
console.log('First Tickets:');
console.log(tickets.getTickets());
console.log('Second Tickets:');
console.log(tickets2.getTickets());
