function areaFinder(width1, height1, width2, height2){
    let area = (width1 * height1) + (width2 * height2);
    let final = Math.min(width1, width2) * Math.min(height1, height2);
    console.log(area - final);
    }  