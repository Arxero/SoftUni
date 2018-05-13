function coneVolume(radius, height){
    let volume = (Math.PI * (radius * radius) * height) / 3;
    console.log(`volume = ${volume}`);

    let s = Math.sqrt(Math.pow(radius, 2) + Math.pow(height, 2))
    let L = Math.PI * radius * s;
    let B = Math.PI * Math.pow(radius, 2);   
    let area = L + B;
    console.log(`area = ${area}`);
}