function format(input) {
    let pattern1 = /(?![.,!?:;])\s{2,}/g;
    let pattern2 = /\s+(?=[.,!?:;])/g;
    let pattern3 = /(?![.])\s+(?=\d+)/g;
    let pattern4 = /"(.+)"/g;
    //let test = pattern1.exec(input);
    let result = input.replace(pattern1, ' ');
    result = result.replace(pattern2, '');
    result = result.replace(pattern3, '');
    let trimMatch = pattern4.exec(result);
    trimMatch = `"${trimMatch[1].trim()}"`;
    result = result.replace(pattern4, trimMatch);
    console.log(result);

    function solve([text]) {
        console.log(text
            .replace(/[ ]*([.,!?:;])[ ]*/g, (match, g1) => `${g1} `)
            .replace(/\. (?=[0-9])/g, (match) => `.`)
            .replace(/" *(.+?) *"/g, (match, g1) => `"${g1}"`)
            .replace(/([.,!?:;]) (?=[.,!?:;])/g, (match, g1) => g1));
    }
}
format(`Terribly formatted text . With chaotic spacings." Terrible quoting   "  !  Also this date is pretty confusing : 20   .   12.   16 .`);