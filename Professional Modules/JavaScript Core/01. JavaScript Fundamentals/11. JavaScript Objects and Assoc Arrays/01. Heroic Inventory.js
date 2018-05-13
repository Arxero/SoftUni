function heroInventory(input) {
    let inventory = [];

    for (let row of input) {
        let data = row.split(' / ');
        let [name, level] = data;
        let items = [];

        if (data.length > 2) {
            items = data[2].split(', ');
        }
        let obj = {
            name: name,
            level: Number(level),
            items: items
        };
        inventory.push(obj);
    }
    console.log(JSON.stringify(inventory));
}
// heroInventory([
//     'Isacc / 25 / Apple, GravityGun',
// 'Derek / 12 / BarrelVest, DestructionSword',
// 'Hes / 1 / Desolator, Sentinel, Antara'
// ]);