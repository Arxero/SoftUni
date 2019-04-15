function solution(input) {
    let houses = input.shift().split('@').map(x => +x)
    let santaIndex = 0

    for (let i = 0; i < input.length - 1; i++) {
        let jumpLength = +input[i].split(' ')[1]
        santaIndex = (santaIndex + jumpLength) % houses.length
       
        if (houses[santaIndex] == 0) {
            console.log(`House ${santaIndex} will have a Merry Christmas.`)
        }
        houses[santaIndex] -= 2 
    }

    console.log(`Santa's last position was ${santaIndex}.`)
    houses = houses.filter(x => x > 0)
    
    if (houses.length) {
        console.log(`Santa has failed ${houses.length} houses.`)
    } else {
        console.log('Mission was successful.')
    } 
}
//solution(['6@6@6', 'Jump 2', 'Jump 2', 'Merry Xmas!'])
//solution(['10@10@10@2', 'Jump 1', 'Jump 2', 'Merry Xmas!'])
solution(['2@4@2',
    'Jump 2',
    'Jump 2',
    'Jump 8',
    'Jump 3',
    'Jump 1',
    'Merry Xmas!']
)