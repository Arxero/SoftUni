function hungry(portions, commands) {
    // let portions = input[0];
    //let commands = input[1];
    let mealsEaten = 0;

    for (let i = 0; i < commands.length; i++) {
        let currentCommand = commands[i].split(' ');

        if (currentCommand[0] == 'End') {
            break;
        }

        switch (currentCommand[0]) {
            case 'Serve':
                if (portions.length < 1) {
                    break;
                }
                let serving = portions.pop();
                console.log(`${serving} served!`);
                break;
            case 'Eat':
                if (portions.length < 1) {
                    break;
                }
                let eaten = portions.shift();
                mealsEaten++;
                console.log(`${eaten} eaten`);
                break;
            case 'Add':
            if (currentCommand[1] == undefined) break;
                //let added = currentCommand.pop();
                portions.unshift(currentCommand[1]);
                break;
            case 'Consume':
                mealsEaten += consumed(currentCommand[1], currentCommand[2], portions);
                
                break;
            case 'Shift':
                shifted(currentCommand[1], currentCommand[2], portions);
                break;
        }
    }

    if (portions.length > 0) {
        console.log(`Meals left: ${portions.join(', ')}`);
    }
    else {
        console.log('The food is gone');
    }
    console.log(`Meals eaten: ${mealsEaten}`);

    //functions----------------------------------------------
    function consumed(a, b, meals) {
        let start = Number(a);
        let end = Number(b);
        if (meals[a] != undefined && meals[b] != undefined) {
            let count = end - start + 1;
            meals.splice(start, count);
            console.log('Burp!');
            return count;
        }
        else{
            return 0;
        }

    }

    function shifted(a, b, meals) {
        let start = Number(a);
        let end = Number(b);
        if (meals[a] != undefined && meals[b] != undefined) {
            let elementA = meals[start];
            let elementB = meals[end];
            meals[start] = elementB;
            meals[end] = elementA;
        }

    }
}
// hungry(
//     ['chicken', 'steak', 'eggs'],
//     ['Serve',
//         'Eat',
//         'End',
//         'Shift 0 1',
//         'Consume 0 1']
// );

// hungry(
//     ['carrots', 'apple', 'beet'],
//     ['Consume 0 2',
//         'End',]
// );

// hungry(
//     ['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],
//     ['Add spaghetti',
//         'Shift 0 1',
//         'Consume 1 4',
//         'End']
// );
