function getDistance3D(n){
    let pointA = {x: n[0], y: n[1], z: n[2]};
    let pointB = {x: n[3], y: n[4], z: n[5]};

    let x = Math.pow(pointA.x - pointB.x, 2);
    let y = Math.pow(pointA.y - pointB.y, 2);
    let z = Math.pow(pointA.z - pointB.z, 2);

    let sum = x + y + z;
    let distance = Math.sqrt(sum)
    console.log(distance);
}

