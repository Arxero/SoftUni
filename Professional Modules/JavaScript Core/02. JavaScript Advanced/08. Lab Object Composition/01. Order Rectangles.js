function solution(input) {
    for (let i = 0; i < input.length; i++) {
        input[i] = {

            width: input[i][0],
            height: input[i][1],
            area: function () {
                return this.width * this.height
            },
            compareTo: function (other) {
                let diff = other.area() - this.area()
                if (diff !== 0) {
                    return diff
                }else {
                    return  other.width - this.width
                }
            }
        }
    }
    return input.sort((a, b) => a.compareTo(b))
}
//console.log(solution([[10, 5], [5, 12]]));
