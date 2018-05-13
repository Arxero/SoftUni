function smallestTwo(input){
    let result = input.sort((a, b) => a - b)
    .filter((e, i) => i < 2)
    .join(' ');
    console.log(result);
}
//smallestTwo([30, 15, 50, 5]);
//smallestTwo([3, 0, 10, 4, 7, 3]);