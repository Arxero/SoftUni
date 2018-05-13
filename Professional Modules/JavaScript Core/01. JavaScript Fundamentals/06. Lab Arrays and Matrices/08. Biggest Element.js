function getBiggest(matrix) {
    let result = [];
    for (let i = 0; i < matrix.length; i++) {
        let biggest = matrix[i].sort((a, b) => b - a).slice(0, 1).join();
        result.push(biggest);
    }
    console.log(result.sort((a, b) => b - a).slice(0, 1).join());
}
//getBiggest([[20, 50, 10], [8, 33, 145]]);
//getBiggest([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);