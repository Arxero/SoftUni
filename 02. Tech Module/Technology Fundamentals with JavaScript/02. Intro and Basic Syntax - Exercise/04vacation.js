function solution(people, group, day) {
    group = group.toLowerCase()
    day = day.toLowerCase()
    let totalPrice = 0
    let bussinessPrice = 0
    
    if (group == 'students') {
        switch (day) {
            case 'friday':
                totalPrice = people * 8.45
                break;
            case 'saturday':
                totalPrice = people * 9.8
                break;
            case 'sunday':
                totalPrice = people * 10.46
                break;
        }
    } else if (group == 'business') {
        switch (day) {
            case 'friday':
                totalPrice = people * 10.9
                bussinessPrice = 10.9
                break;
            case 'saturday':
                totalPrice = people * 15.6
                bussinessPrice = 15.6
                break;
            case 'sunday':
                totalPrice = people * 16
                bussinessPrice = 16
                break;
        }
    } else if (group == 'regular') {
        switch (day) {
            case 'friday':
                totalPrice = people * 15
                break;
            case 'saturday':
                totalPrice = people * 20
                break;
            case 'sunday':
                totalPrice = people * 22.5
                break;
        }
    }

    if (group == 'students' && people >= 30) {
        totalPrice = totalPrice - (totalPrice / 100) * 15
    } else if (group == 'business' && people >= 100) {
        totalPrice = totalPrice - (10 * bussinessPrice)
    } else if (group == 'regular' && (people >= 10 && people <= 20)) {
        totalPrice = totalPrice - (totalPrice / 100) * 5
    }

    console.log('Total price: ' + totalPrice.toFixed(2))
}
