function getData(input) {
    let pattern = /^([A-Z][a-zA-Z]*) - ([1-9][0-9]*) - ([a-zA-Z0-9 -]+)$/;

    for (const element of input) {
        let result = pattern.exec(element);
        if (result) {
            let [match, name, salary, position] = result;
            console.log(`Name: ${name}`);
            console.log(`Position: ${position}`);
            console.log(`Salary: ${salary}`);
        }
    }
}
//getData(['Isacc - 1000 - CEO', 'Ivan - 500 - Employee', 'Peter - 500 - Employee']);
//getData(['Isacc - 1000 - CEO']);