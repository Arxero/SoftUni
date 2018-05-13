function checker(input) {
    let x1 = input[0];
    let y1 = input[1];
    let x2 = input[2];
    let y2 = input[3];

    function isValid(x1, y1, x2, y2) {
        let distance = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));
        return distance;
    }

    if (Number.isInteger(isValid(x1, y1, 0, 0))) {
        console.log(`{${x1}, ${y1}} to {${0}, ${0}} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {${0}, ${0}} is invalid`);
    }

    if (Number.isInteger(isValid(0, 0, x2, y2))) {
        console.log(`{${x2}, ${y2}} to {${0}, ${0}} is valid`);
    }
    else{
        console.log(`{${x2}, ${y2}} to {${0}, ${0}} is invalid`);
    }

    if (Number.isInteger(isValid(x1, y1, x2, y2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}
//checker([3, 0, 0, 4]);
//checker([2, 1, 1, 1]);