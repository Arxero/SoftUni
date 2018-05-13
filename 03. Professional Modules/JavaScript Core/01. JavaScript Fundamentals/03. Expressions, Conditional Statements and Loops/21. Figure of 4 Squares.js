function printFigure(n){
    
    if (n == 2) {
        topAndBot(n);
    }
    else if (n == 3 || n == 4) {
        for (let i = 0; i < 3; i++) {
            topAndBot(n);          
        }  
    }
    else{
        topAndBot(n);
        if (n % 2 != 0) {
            for (let i = 0; i < (n - 4) / 2; i++) {
                middle(n);       
            }
        }
        else{
            for (let i = 0; i < Math.floor((n - 3) / 2); i++) {
                middle(n);       
            }
        }
        topAndBot(n);
        if (n % 2 != 0) {
            for (let i = 0; i < (n - 4) / 2; i++) {
                middle(n);       
            }
        }
        else{
            for (let i = 0; i < Math.floor((n - 3) / 2); i++) {
                middle(n);       
            }
        }
        topAndBot(n);
    }
    

//top and bottom
function topAndBot(n){
    let figure = '';
    //top and bot
    for (let row = 0; row < 3; row++) {
        figure += '+';
        for (let i = 0; i < n - 2; i++) {
            if (row == 2 && n != 2) {
                break
            }
            figure += '-';
        }
    }
    console.log(figure);
}

//middle
function middle(n){
    let figure = '';
    //top and bot
    for (let row = 0; row < 3; row++) {
        figure += '|';
        for (let i = 0; i < n - 2; i++) {
            if (row == 2) {
                break
            }
            figure += ' ';
        }
    }
    console.log(figure);
}   
}
//printFigure(2);