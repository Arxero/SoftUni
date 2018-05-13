function aggreagateElements(input) {
    function aggreagate(elements, initValue, arrowFunc) {
        let result = initValue;
        for (let i = 0; i < elements.length; i++) {
            result = arrowFunc(result, elements[i])
        }
        console.log(result);
    }
    aggreagate(input, 0, (a, b) => a + b);
    aggreagate(input, 0, (a, b) => a + 1 / b);
    aggreagate(input, '', (a, b) => a + b);
}
//aggreagateElements([1, 2, 3]);