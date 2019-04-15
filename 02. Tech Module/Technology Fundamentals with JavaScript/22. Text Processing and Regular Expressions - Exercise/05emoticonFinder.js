function solution(input) {
    input.split(' ').forEach(x => {
        if (x.startsWith(':') && x.length == 2) {
            console.log(x)
        }
    })  
}