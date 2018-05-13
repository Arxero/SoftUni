function templateFormat(input) {
    let question = '';
    let answer = '';

    let header = '<?xml version="1.0" encoding="UTF-8"?>\n';
    header += '<quiz>';
    console.log(header);

    for (let i = 0; i < input.length; i += 2) {
        question = input[i];
        answer = input[i + 1];
        print(question, answer)
    }
    console.log('</quiz>');

    function print(question, answer) {
        let result = '  <question>\n';
        result += `    ${question}\n`
        result += '  </question>\n'
        result += '  <answer>\n';
        result += `    ${answer}\n`;
        result += '  </answer>';
        console.log(result);
    }
}
//templateFormat(["Who was the forty-second president of the U.S.A.?", "William Jefferson Clinton"]);
//templateFormat(["Dry ice is a frozen form of which gas?", "Carbon Dioxide", "What is the brightest star in the night sky?", "Sirius"]);