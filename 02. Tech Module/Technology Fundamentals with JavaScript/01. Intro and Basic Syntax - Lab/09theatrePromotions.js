function solution(day, age) {
    day = day.toLowerCase()

    switch (day) {
        case 'weekday':
            if (age >= 0 && age <= 18) {
                console.log('12$')
            } else if (age >= 19 && age <= 64) {
                console.log('18$')
            } else if (age >= 20 && age <= 122) {
                console.log('12$')
            } else {
                console.log('Error!')
            }
            break;
        case 'weekend':
            if (age >= 0 && age <= 18) {
                console.log('15$')
            } else if (age >= 19 && age <= 64) {
                console.log('20$')
            } else if (age >= 20 && age <= 122) {
                console.log('15$')
            } else {
                console.log('Error!')
            }
            break;
        case 'holiday':
            if (age >= 0 && age <= 18) {
                console.log('5$')
            } else if (age >= 19 && age <= 64) {
                console.log('12$')
            } else if (age >= 20 && age <= 122) {
                console.log('10$')
            } else {
                console.log('Error!')
            }
            break;
    }
}
solution('weekday', 19)