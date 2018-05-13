function toJSON(input) {
    let arr = [];

    for (let i = 1; i < input.length; i++) {
        let data = input[i].split(/\s*[|]+\s*/).filter(x => x != '');
        let obj = {
            Town: data[0],
            Latitude: Number(data[1]),
            Longitude: Number(data[2])
        }; 
        arr.push(obj);
    }
    console.log(JSON.stringify(arr));
}
// toJSON(['| Town | Latitude | Longitude |', '| Sofia | 42.696552 | 23.32601 |', '| Beijing | 39.913818 | 116.363625 |']);
// toJSON(['| Town | Latitude | Longitude |', '| Veliko Turnovo | 43.0757 | 25.6172 |', '| Monatevideo | 34.50 | 56.11 |']);