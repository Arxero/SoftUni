function score(input) {
    let str = JSON.parse(input);

    let result = '<table>\n';
    result += '  <tr><th>name</th><th>score</th></tr>\n';
    for (let element of str) {
        result += `  <tr><td>${escape(element.name)}</td><td>${element.score}</td></tr>\n`;
    }
    result += '</table>';

    function escape(input) {
        input = input.replace(/[&]/g, '&amp;');
        input = input.replace(/[<]/g, '&lt;');
        input = input.replace(/[>]/g, '&gt;');
        input = input.replace(/["]/g, '&quot;');
        input = input.replace(/[']/g, '&#39;');
        return input;
    }
    console.log(result);
}
//score('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]');
// score('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]');
