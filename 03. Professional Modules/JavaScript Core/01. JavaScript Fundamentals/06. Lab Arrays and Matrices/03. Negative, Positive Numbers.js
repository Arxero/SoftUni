function numbers(input){
    let arr = [];
    for (let i = 0; i < input.length; i++) {
        if (input[i] < 0) {
            arr.unshift(input[i]);
        }
        else{
            arr.push(input[i])
        }
    }
    for (const iterator of arr) {
        console.log(iterator);
    }
}
//numbers([7, -2, 8, 9]);
//numbers([3, -2, 0, -1]);