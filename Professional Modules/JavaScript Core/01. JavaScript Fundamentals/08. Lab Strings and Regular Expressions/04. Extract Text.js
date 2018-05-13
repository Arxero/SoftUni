function extract(input) {
    let left = '(';
    let right = ')';
    let result = [];
    let leftIndex = input.indexOf(left);

    while (leftIndex > -1) {
        let rightIndex = input.indexOf(right, leftIndex);
        if (rightIndex == -1) break;
        result.push(input.substring(leftIndex + 1, rightIndex));
        leftIndex = input.indexOf(left, rightIndex);
        
    }
    console.log(result.join(', '));
}
//extract('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink), (even aples');