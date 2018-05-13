function pointInRect([a, a1, b, b1, c, c1]){
    let [x, y, xMin, xMax, yMin, yMax] = [a, a1, b, b1, c, c1];
    
    if ((x >= xMin && x <= xMax) && (y >= yMin && y <= yMax)) {
        console.log('inside');      
    }
    else{
        console.log('outside');
    }
}