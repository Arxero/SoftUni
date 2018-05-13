function getDay(n) {
    let week = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
    for (let i = 0; i < week.length; i++) {
        if (n == week[i]) {
            console.log(i + 1);
            break;
        }
        if (i == 6) {
            console.log('error');
        }
    }
}