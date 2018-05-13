function solution(input) {
    let airplanes = new Set()
    let port = new Map()
    //console.log(new Date().toString())

    for (let row of input) {
        let splitter = row.split(' ')
        let plane = splitter[0]
        let town = splitter[1]
        let ppl = Number(splitter[2])
        let action = splitter[3]

        if (action == 'depart') {
            if (!airplanes.has(plane)) continue;
            else {
                airplanes.delete(plane);
            }
        }
        if (action == 'land') {
            if (airplanes.has(plane)) continue;
            else {
                airplanes.add(plane);
            }
        }


        if (!port.has(town)) {
            port.set(town, { airplanes: [], arrivals: 0, departures: 0 });
        }
        if (!port.get(town).airplanes.includes(plane)) {
            port.get(town).airplanes.push(plane);
        }
        if (action == "land") {
            port.get(town).arrivals += ppl;
        } else {
            port.get(town).departures += ppl;
        }
    }

    console.log("Planes left:");
    [...airplanes].sort((p1, p2) => p1.localeCompare(p2)).forEach(p => console.log(`- ${p}`));
    [...port].sort((t1, t2) => {
        if (t1[1].arrivals < t2[1].arrivals) return 1;
        if (t1[1].arrivals > t2[1].arrivals) return -1;
        return t1[0].localeCompare(t2[0]);
    }).forEach(logData);

    function logData(town) {
        //console.log(`${town[0]} ${town[1].arrivals} ${town[1].departures}`);
        console.log(town[0]);
        console.log(`Arrivals: ${town[1].arrivals}`);
        console.log(`Departures: ${town[1].departures}`);
        console.log("Planes:");
        town[1].airplanes.sort((p1, p2) => p1.localeCompare(p2)).forEach(p => console.log(`-- ${p}`));
    }
}

solution([
    "Boeing474 Madrid 300 land",
    "AirForceOne WashingtonDC 178 land",
    "Airbus London 265 depart",
    "ATR72 WashingtonDC 272 land",
    "ATR72 Madrid 135 depart"
])