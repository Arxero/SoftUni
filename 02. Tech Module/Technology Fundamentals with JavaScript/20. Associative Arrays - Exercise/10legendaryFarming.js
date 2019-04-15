function solution(input) {
    input = input.split(' ')
    let keyMaterials = {}
    let junk = {}

    for (let i = 0; i < input.length; i += 2) {
        let quantity = +input[i]
        let material = input[i + 1].toLowerCase()

        if (material == 'shards' || material == 'fragments' || material == 'motes') {
            if (!keyMaterials.hasOwnProperty(material)) {
                keyMaterials['shards'] = 0
                keyMaterials['fragments'] = 0
                keyMaterials['motes'] = 0
                keyMaterials[material] = quantity
                if (keyMaterials[material] >= 250) {
                    keyMaterials[material] -= 250

                    switch (material) {
                        case 'shards': console.log('Shadowmourne obtained!'); break
                        case 'fragments': console.log('Valanyr obtained!'); break
                        case 'motes': console.log('Dragonwrath obtained!'); break
                    }
                    break
                }
            } else {
                keyMaterials[material] += quantity
                if (keyMaterials[material] >= 250) {
                    keyMaterials[material] -= 250

                    switch (material) {
                        case 'shards': console.log('Shadowmourne obtained!'); break
                        case 'fragments': console.log('Valanyr obtained!'); break
                        case 'motes': console.log('Dragonwrath obtained!'); break
                    }
                    break
                }
            }
        } else {
            if (!junk.hasOwnProperty(material)) {
                junk[material] = quantity
            } else {
                junk[material] += quantity
            }
        }
    }

    Object.entries(keyMaterials).sort((a, b) => {
        if (a[1] < b[1]) {
            return 1
        } else if (a[1] == b[1]) {
            return a[0].localeCompare(b[0])
        }
    }).forEach(x => console.log(x[0].toLowerCase() + ': ' + x[1]))

    Object.entries(junk)
        .sort((a, b) => a[0].localeCompare(b[0]))
        .forEach(x => console.log(x[0].toLowerCase() + ': ' + x[1]))
}