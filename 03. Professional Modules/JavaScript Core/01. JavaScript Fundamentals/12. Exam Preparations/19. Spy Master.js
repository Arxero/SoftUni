function spy(input) {
    let keyInput = input.shift();
    let text = '';
    for (let row of input) {
        text += row + '\n';
    }

    let keyPattern = /(?:^|\s)([a-zA-Z]+)/i;
    let key = keyPattern.exec(keyInput).reduce((a, b) => b);

    let pattern = new RegExp (`${key}`, 'gi')
    let textReplaced = text.replace(pattern, key);

    let messagePattern = new RegExp(`(?:${key}\\s+)([A-Z!%$#]{8,})(?:\\s|\\.|,|$)`, 'g');
    let messageMatch = messagePattern.exec(textReplaced);
    
    while (messageMatch) {
        let message = messageMatch[1];
        message = message
        .replace(/[!]/g, '1')
        .replace(/[%]/g, '2')
        .replace(/[#]/g, '3')
        .replace(/[$]/g, '4')
        .toLowerCase();
        text = text.replace(messageMatch[1], message );
        //console.log(message);
        messageMatch = messagePattern.exec(textReplaced);
        
    }
    console.log(text);
}
// spy([
//     ` specialKey`,
//     `In this text the specialKey HELLOWORLD! is correct, but`,
//     `the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while`,
//     `SpeCIaLkeY   SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!`
// ]);