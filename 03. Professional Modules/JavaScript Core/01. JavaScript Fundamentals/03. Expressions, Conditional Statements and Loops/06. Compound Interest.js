function getCompound(input){
    let money = input[0]; 
    let frequency = 12 / input[2]; 
    let rate = (((input[1] / 100) / frequency) + 1);
    let time = input[3] * frequency;

    let FV = money * (Math.pow(rate, time));
    console.log(FV.toFixed(2));
}