function lost(keyword, text) {
    let message = new RegExp(`${keyword}(.*?)${keyword}`);
    let matchM = text.match(message);
    let pattern = /(north|east)\D*(\d{2})[^,]*(,)\D*(\d{6})/gi;
    
    let north = '';
    let east = '';
    let match = pattern.exec(text);

    while (match) {
        if (match[1].toLowerCase() == 'north') {
            north = `${match[2]}.${match[4]}`;
        }
        else {
            east = `${match[2]}.${match[4]}`;
        }
        match = pattern.exec(text);
    }
    
    console.log(`${north} N`);
    console.log(`${east} E`);
    console.log(`Message: ${matchM[1]}`);
}
lost(
'<>',
'o u%&lu43t&^ftgv><nortH4276hrv756dcc,  jytbu64574655k <>ThE sanDwich is iN the refrIGErator<>yl i75evEAsTer23,lfwe 987324tlblu6b'
);

// lost(
// '4ds',
// 'eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532'
//     );