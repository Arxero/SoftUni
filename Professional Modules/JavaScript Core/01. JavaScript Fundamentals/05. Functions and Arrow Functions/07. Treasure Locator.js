function locator(input) {
    for (let i = 0; i < input.length; i+=2) {
        let x = input[i];
        let y = input[i + 1];

        if (tuvalu(x, y)) {
            console.log(tuvalu(x, y));
        }
        else if (tonga(x, y)) {
            console.log(tonga(x, y));
        }
        else if (samoa(x, y)) {
            console.log(samoa(x, y));
        }
        else if (cook(x, y)) {
            console.log(cook(x , y));
        }
        else if (tokelau(x, y)) {
            console.log(tokelau(x, y));
        }
        else{
            console.log('On the bottom of the ocean');
        }
    }

    function tuvalu(x, y) {
        x1 = 1; x2 = 3;
        y1 = 1; y2 = 3;
        if (x >= x1 && x <= x2) {
            if (y >= y1 && y <= y2) {
                return 'Tuvalu';
            }
        }
    }

    function tonga(x, y) {
        x1 = 0; x2 = 2;
        y1 = 6; y2 = 8;
        if (x >= x1 && x <= x2) {
            if (y >= y1 && y <= y2) {
                return 'Tonga';
            }
        }
    }

    function samoa(x, y) {
        x1 = 5; x2 = 7;
        y1 = 3; y2 = 6;
        if (x >= x1 && x <= x2) {
            if (y >= y1 && y <= y2) {
                return 'Samoa';
            }
        }
    }

    function cook(x, y) {
        x1 = 4; x2 = 9;
        y1 = 7; y2 = 8;
        if (x >= x1 && x <= x2) {
            if (y >= y1 && y <= y2) {
                return 'Cook';
            }
        }
    }

    function tokelau(x, y) {
        x1 = 8; x2 = 9;
        y1 = 0; y2 = 1;
        if (x >= x1 && x <= x2) {
            if (y >= y1 && y <= y2) {
                return 'Tokelau';
            }
        }
    }

}
//locator([1, 3]);
//locator([4, 2, 1.5, 6.5, 1, 3]);