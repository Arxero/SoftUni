function xml(input) {
    let pattern = /^<message ([a-z]+="[a-zA-Z0-9\s\.]+"\s*)+>((?:.|\n)+?)<\/message>$/;
    let patternTo = /\bto="([a-zA-Z0-9\s\.]+)"/;
    let patternfrom = /\bfrom="([a-zA-Z0-9\s\.]+)"/;
    let attributesPattern;
    let message = pattern.exec(input);
    let toMatch = patternTo.exec(input);
    let fromMatch = patternfrom.exec(input);

    let to = '';
    let from = '';

    if (message) {
        if (toMatch && fromMatch) {
            to = toMatch[1];
            from = fromMatch[1];
        }
        else {
            console.log('Missing attributes');
            return;
        }
    }
    else {
        console.log('Invalid message format');
        return;
    }

    message[2] = message[2].replace(/\n/g, `</p>\n    <p>`)

    let result = '<article>\n';
    result += `  <div>From: <span class="sender">${from}</span></div>\n`;
    result += `  <div>To: <span class="recipient">${to}</span></div>\n`;
    result += `  <div>\n`;
    result += `    <p>${message[2]}</p>\n`;
    result += `  </div>\n`;
    result += '</article>\n';
    console.log(result);

}
//xml(`<message to="Bob" from="Alice" timestamp="1497254092">Hey man, what's up?</message>`);
//xml(`<message from="Alice" timestamp="1497254112">Same old, same old</message>`);
//xml(`<message to="Bob" from="Alice" timestamp="1497254114">Same old, same old\nLet's go out for a beer</message>`);
//xml(`<message mailto="everyone" from="Grandma" to="Everyone">FWD: FWD: FWD: FWD: Forwards from grandma</message>`);
//xml(`<message to="Jimmy">Not sure if this will work</message>`)