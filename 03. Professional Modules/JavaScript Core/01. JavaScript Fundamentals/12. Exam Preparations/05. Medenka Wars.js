function menedka(input) {
    let damageDefault = 60;

    let naskorDamage = 0;
    let naskorDamagePrevious = 0;
    let counterNaskor = 0;

    let viktorDamage = 0;
    let vitkorDamagePrevious = 0;
    let counterVitkor = 0;

    for (let row of input) {
        let splitter = row.split(' ');
        let countOfMedenka = Number(splitter[0]);
        let damageType = splitter[1];
        let medenkaDamage = countOfMedenka * damageDefault;

        if (damageType == 'white') {
            if (medenkaDamage == vitkorDamagePrevious) {
                counterVitkor++;

                if (counterVitkor == 2) {
                    medenkaDamage *= 2.75;
                    counterVitkor = 0;
                }
            }
            else {
                vitkorDamagePrevious = medenkaDamage;
                counterVitkor = 1;
            }
            viktorDamage += medenkaDamage;
        }
        else if (damageType == 'dark') {
            if (medenkaDamage == naskorDamagePrevious) {
                counterNaskor++;

                if (counterNaskor == 5) {
                    medenkaDamage *= 4.5;
                    counterNaskor = 0;
                }
            }
            else {
                naskorDamagePrevious = medenkaDamage;
                counterNaskor = 1;
            }
            naskorDamage += medenkaDamage;
        }
    }

    if (viktorDamage > naskorDamage) {
        console.log(`Winner - Vitkor`);
        console.log(`Damage - ${viktorDamage}`);
    }
    else {
        console.log(`Winner - Naskor`);
        console.log(`Damage - ${naskorDamage}`);
    }
}
// menedka([
//     '5 white medenkas',
//     '5 dark medenkas',
//     '5 white medenkas',
//     '5 white medenkas',
//     '5 dark medenkas',
//     '5 dark medenkas',
//     '5 dark medenkas',
//     '5 dark medenkas',
//     '4 white medenkas'
// ]);

// menedka([
//     '2 dark medenkas',
//     '1 white medenkas',
//     '2 dark medenkas',
//     '2 dark medenkas',
//     '15 white medenkas',
//     '2 dark medenkas',
//     '2 dark medenkas'
// ]);