function solution(input) {
    let inventory = input.shift().split(' ')

    for (let row of input) {
        row = row.split(' ')
        let command = row[0].toLowerCase()
        let equipment = row[1]

        switch (command) {
            case 'buy':
                if (!inventory.includes(equipment)) {
                    inventory.push(equipment)
                }
                break;
            case 'trash':
                let indexOfTrashEquipment = inventory.indexOf(equipment)
                if (indexOfTrashEquipment >= 0) {
                    inventory.splice(indexOfTrashEquipment, 1)
                }
                break;
            case 'repair':
                let indexOfRepairEquipment = inventory.indexOf(equipment)
                if (indexOfRepairEquipment >= 0) {
                    let elementRepair = inventory.splice(indexOfRepairEquipment, 1)[0]
                    inventory.push(elementRepair)
                }
                break;
            case 'upgrade':
                let equipmentLookout = equipment.split('-')[0]
                let material = equipment.split('-')[1]
                let upgrade = equipmentLookout + ':' + material
                let indexOfUpgradeEquipment = inventory.indexOf(equipmentLookout)
                if (indexOfUpgradeEquipment >= 0) {
                    inventory.splice(indexOfUpgradeEquipment + 1, 0, upgrade)
                }
                break;
        }
    }

    console.log(inventory.join(' '))
}
