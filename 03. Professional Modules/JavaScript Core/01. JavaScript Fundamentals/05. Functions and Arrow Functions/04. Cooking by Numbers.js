function cooking(input) {
    let n = input[0];

    for (let i = 1; i < input.length; i++) {
        let command = input[i];
        
        switch (command) {
            case 'chop':
                let chop = n => n / 2;
                console.log(chop(n));
                n = chop(n);
                break;
            case 'dice':
                let dice = n => Math.sqrt(n);
                console.log(dice(n));
                n = dice(n);
                break;
            case 'spice':
                let spice = n => n + 1;
                console.log(spice(n));
                n = spice(n);
                break;
            case 'bake':
                let bake = n => n * 3;
                console.log(bake(n));
                n = bake(n);
                break;
            case 'fillet':
                let fillet = n => n - (n * 0.2);
                console.log(fillet(n));
                n = fillet(n);
                break;
        }
    }
}
//cooking([32, 'chop', 'chop', 'chop', 'chop', 'chop']);
//cooking([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);