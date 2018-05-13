function calendar([day, month, year]) {
    let today = new Date(year, month - 1, day)
    let months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"]
    let caption = months[today.getMonth()] + ' ' + today.getFullYear()

    let selector = $('#content').append($('<table>')
        .append($('<caption>').text(caption))
        .append($('<tbody>')))

    let numberOfDays = 0
    let lastDayInMonth = new Date(year, month, 0)
    numberOfDays += lastDayInMonth.getDate()
    let previousMonthDays = (new Date(year, month - 1, 0)).getDay()
    let nextMonthDays = (7 - new Date(year, month, 0).getDay() % 7) % 7
    numberOfDays += previousMonthDays + nextMonthDays

    $('tbody').append($('<tr>')
        .append($('<th>').text('Mon'))
        .append($('<th>').text('Tue'))
        .append($('<th>').text('Wed'))
        .append($('<th>').text('Thu'))
        .append($('<th>').text('Fri'))
        .append($('<th>').text('Sat'))
        .append($('<th>').text('Sun')))

    let daysCounter = 0 - previousMonthDays + 1
    console.log(daysCounter);
    console.log(lastDayInMonth.getDate());
    

    for (let i = 0; i < numberOfDays / 7; i++) {
        $('tbody').append($('<tr>'))
        for (let j = 0; j < 7; j++) {
            let currentDay;

            if (daysCounter < 1 || daysCounter > lastDayInMonth.getDate()) {
                currentDay = ''
            } else {
                currentDay = daysCounter
            }
            daysCounter++

            if (currentDay == today.getDate()) {
                $('tbody tr:last-child').append($('<td>').addClass('today').text(currentDay))
            } else {
                $('tbody tr:last-child').append($('<td>').text(currentDay))
            }
        }
    }
    console.log(selector[0]);
}