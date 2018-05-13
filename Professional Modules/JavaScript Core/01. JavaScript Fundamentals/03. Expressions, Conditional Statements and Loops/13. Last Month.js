function getLastDay([day, month, year]){
    let lastDay = 0;
    let theMonth = month - 1;
    theMonth == 0 ? theMonth = 12 : theMonth;
        switch (theMonth) {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                lastDay = 31;
                break;
            case 2:
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                lastDay = 29;
            }
            else{
                lastDay = 28;
            }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                lastDay = 30;    
        }
        console.log(lastDay);
    }