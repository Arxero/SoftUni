function getDistance(input){
    let dist1 = input[0] * (input[2] / 60);
    let dist2 = input[1] * (input[2] / 60);
    let delta = Math.abs(dist1 - dist2);
    delta *= 1000 / 60;
    console.log(delta);
}