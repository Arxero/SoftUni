function solution(input) {
    let games = input[0].split(' ')

    for (let i = 1; i < input.length; i++) {
        let inputLine = input[i].split(' ')
        let command = inputLine[0]
        let game = inputLine[1]
        let expansion = ''
        
        if (command == 'Expansion') {
            let gameWithExpansion = game.split('-')
            game = gameWithExpansion[0]
            expansion = game + ':' + gameWithExpansion[1]
        }
        let indexOfGame = games.indexOf(game)

        switch (command) {
            case 'Install':
                if (!games.includes(game)) {
                    games.push(game)
                }
                break;
            case 'Uninstall':
                if (games.includes(game)) {
                    games.splice(indexOfGame, 1)
                }
                break;
            case 'Update':
                if (games.includes(game)) {
                    games.splice(indexOfGame, 1)
                    games.push(game)
                }
                break;
            case 'Expansion':
                if (games.includes(game)) {
                    games.splice(indexOfGame + 1, 0, expansion)
                }
                break;
        }
    }
    
    console.log(games.join(' '))
}

solution([
    'CS WoW Diablo',
    'Install LoL',
    'Uninstall WoW',
    'Update Diablo',
    'Expansion CS-Go',
    'Play!'
])
