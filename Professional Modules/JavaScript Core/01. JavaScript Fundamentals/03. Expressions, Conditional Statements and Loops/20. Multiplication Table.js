function multiplicationTable(n){
    let table = '<table border="1">\n';
    table += '<tr><th>x</th>';

    for (let headingRow = 1; headingRow <= n; headingRow++) {
        table += `<th>${headingRow}</th>`;
    }
    table += '</tr>\n';

    for (let headingCol = 1; headingCol <= n; headingCol++) {
        table += `<tr><th>${headingCol}</th>`;

        for (let row = 1; row <= n; row++) {
            table += `<td>${headingCol * row}</td>`;
            
        }
        table += '</tr>\n';
    }    

    table += '</table>';
    console.log(table); //seeing result on the console
    return table; // seeing result in the browser
}
//multiplicationTable(5);