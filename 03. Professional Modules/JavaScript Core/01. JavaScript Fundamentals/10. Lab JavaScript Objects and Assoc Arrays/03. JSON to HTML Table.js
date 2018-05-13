function htmlTable(input) {
    let str = JSON.parse(input);

    let result = '<table>\n';
    let keys = Object.keys(str);

    result += `  <tr>`;
    for (const key of Object.keys(str[0])) {
        result += `<th>${escape(key)}</th>`
    }
    result += `</tr>\n`

    for (const row of keys) {
        result += `  <tr>`;

        for (const element of Object.values(str[row])) {
            result += `<td>${escape(element)}</td>`;
        }

        result += `</tr>\n`;
    }
    result += '</table>';

    function escape(input) {
        if (typeof input === 'string') {
            input = input.replace(/[&]/g, '&amp;');
            input = input.replace(/[<]/g, '&lt;');
            input = input.replace(/[>]/g, '&gt;');
            input = input.replace(/["]/g, '&quot;');
            input = input.replace(/[']/g, '&#39;');
        }
        return input;
    }
    console.log(result);

}
// htmlTable('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]');
// htmlTable(`[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},
// {"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]`);