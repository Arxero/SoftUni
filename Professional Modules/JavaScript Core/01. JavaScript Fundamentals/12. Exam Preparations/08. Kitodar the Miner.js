function kitodar(input) {
    let gold = 0;
    let silver = 0;
    let diamonds = 0;

    for (let row of input) {
        let splitter = row.split(/[\s"]+/).filter(x => x != '');
        let firstWord = splitter[0];
        let ore = '';

        if (firstWord == 'mine') {

            if (splitter.length == 6  && splitter[2] == '-' && splitter[4] == ':') {
                ore = splitter[3];
                switch (ore) {
                    case 'gold':
                        gold += +splitter[5];
                        break;
                    case 'silver':
                        silver += +splitter[5];
                        break;
                    case 'diamonds':
                        diamonds += +splitter[5];
                        break;
                }
            }
            else if (splitter.length == 5 && splitter[1] == '-' && splitter[3] == ':') {
                ore = splitter[2];
                switch (ore) {
                    case 'gold':
                        gold += +splitter[4];
                        break;
                    case 'silver':
                        silver += +splitter[4];
                        break;
                    case 'diamonds':
                        diamonds += +splitter[4];
                        break;
                }
            }

        }
    }
    console.log(`*Silver: ${silver}`);
    console.log(`*Gold: ${gold}`);
    console.log(`*Diamonds: ${diamonds}`);
}
// kitodar([
//     'mine bobovDol - gold: 10"',
//     'mine medenRudnik - silver: 22"',
//     'mine chernoMore - shrimps : 24"',
//     'gold: 50'
// ]);

// kitodar([
//     'mine bobovdol - gold: 10',
//     'mine - diamonds: 5',
//     'mine colas - wood: 10',
//     'mine myMine - silver:  14',
//     'mine silver:14 - silver: 14'
// ]);

// kitodar([
// '    mine mina - golD : 5',
//     'mine mina: gold: 5'
// ]);

// kitodar([
// '    mine mina - gold - 5',
// '    mine mina - silver - 5',
// '    mine mina - diamonds : 5',
// '    mine mina - gold:5'
//     ]);

