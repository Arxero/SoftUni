function wall(input) {
    let arr = input.map(x => Number(x));
    let result = [];

    while (true) {
        arr = arr.filter(x => x < 30);
        for (let i = 0; i < arr.length; i++) {
            let height = arr[i];
            height++;
            arr[i] = height;
        }
        result.push(arr.length * 195);
        arr = arr.filter(x => x < 30);
        if (arr.length == 0) {
            break;
        }
    }
    console.log(result.join(', '));
    console.log(`${result.reduce((a, b) => a + b) * 1900} pesos`);
}
//wall(['21', '25', '28']);
//wall(['17', '22', '17', '19', '17']);
//wall([10, 30, 10, 10, 10]);