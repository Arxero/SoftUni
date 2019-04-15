function solution(input) {
    let noisyKids = input.shift().split('&')

    for (let i = 0; i < input.length - 1; i++) {
        let [command, name, newName] = input[i].split(' ')

        switch (command) {
            case 'Bad':
                if (!noisyKids.includes(name)) {
                    noisyKids.unshift(name)
                }
                break;
            case 'Good':
                if (noisyKids.includes(name)) {
                    let indexOfGoodKid = noisyKids.indexOf(name)
                    noisyKids.splice(indexOfGoodKid, 1)
                }
                break
            case 'Rename':
                if (noisyKids.includes(name)) {
                    let indexOfOldKid = noisyKids.indexOf(name)
                    noisyKids.splice(indexOfOldKid, 1, newName)
                }
                break;
            case 'Rearrange':
                if (noisyKids.includes(name)) {
                    let indexOfReArrangeKid = noisyKids.indexOf(name)
                    noisyKids.splice(indexOfReArrangeKid, 1)
                    noisyKids.push(name)
                }
                break
        }
    }

    console.log(noisyKids.join(', '))
}
