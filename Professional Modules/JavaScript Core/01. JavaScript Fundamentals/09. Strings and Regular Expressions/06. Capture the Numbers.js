function numbers(input) {
    let result = [];
    let pattern = /[0-9]+/g;
    
    for(let row of input) {
        let match = pattern.exec(row);
        while(match) {
            result.push(match[0]);
            match = pattern.exec(row);
        }
    }
    console.log(result.join(' '));
}
//numbers(['The300 What is that?', 'I think it’s the 3rd movie.', 'Lets watch it at 22:45']);
//numbers(['123a456', '789b987', '654c321', '0']);
//numbers(['Let’s go11!!!11!', 'Okey!1!']);