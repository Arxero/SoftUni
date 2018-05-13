function oddProcess(input) {
    let odds = input.filter((e, i) => i % 2 != 0)
    .map(x => x * 2)
    .reverse()
    .join(' ');
    console.log(odds);
}
//oddProcess([10, 15, 20, 25]);
//oddProcess([3, 0, 10, 4, 7, 3]);