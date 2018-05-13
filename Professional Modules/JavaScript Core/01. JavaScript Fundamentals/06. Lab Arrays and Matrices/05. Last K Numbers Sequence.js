function kNumsSequence(n, k) {
    let sequence = [];
    sequence = [1];

    for (let i = 1; i < n; i++) {
        let start = Math.max(0, i - k);
        let end = i - 1;
        let sum = sequence.slice(start, end + k).reduce((a, b) => a + b, 0);
        sequence[i] = sum;
    }
    console.log(sequence.join(' '));
}
//kNumsSequence(6, 3);