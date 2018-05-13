function blade(input) {
    let fingerWidth = 1;
    
    let result = '<table border="1">\n';
    result += '<thead>\n';
    result += '<tr><th colspan="3">Blades</th></tr>\n';
    result += '<tr><th>Length [cm]</th><th>Type</th><th>Application</th></tr>\n';
    result += '</thead>\n';
    result += '<tbody>\n';

    for (let row of input) {
        let bladeLength = Math.floor(row);
        let type = '';
        let knife = '';

        if (bladeLength > 10) {
            type = bladeLength > 40 ? 'sword' : 'dagger';
            switch (bladeLength % 5) {
                case 1: knife = 'blade'; break;
                case 2: knife = 'quite a blade'; break;
                case 3: knife = 'pants-scraper'; break;
                case 4: knife = 'frog-butcher'; break;
                case 0: knife = '*rap-poker'; break;
           
            }
            result += `<tr><td>${bladeLength}</td><td>${type}</td><td>${knife}</td></tr>\n`;
        }
    }
    result += '</tbody>\n';
    result += '</table>\n';
    console.log(result);
}
// blade([
//     '17.8',
//     '19.4',
//     '13',
//     '55.8',
//     '126.96541651',
//     '3'
// ]);