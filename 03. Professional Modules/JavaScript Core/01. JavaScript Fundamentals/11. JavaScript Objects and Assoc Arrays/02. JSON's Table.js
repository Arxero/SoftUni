function JSONsTable(input) {
    let result = '<table>\n';

    for (const row of input) {
        result += '       <tr>\n';
        let data = JSON.parse(row);
        result += `         <td>${data.name}</td>\n`;
        result += `         <td>${data.position}</td>\n`;
        result += `         <td>${data.salary}</td>\n`;
        result += '       <tr>\n';
    }
    result += '</table>';
    console.log(result);
}
// JSONsTable([
//     '{"name":"Pesho","position":"Promenliva","salary":100000}',
//     '{"name":"Teo","position":"Lecturer","salary":1000}',
//     '{"name":"Georgi","position":"Lecturer","salary":1000}'
// ]);