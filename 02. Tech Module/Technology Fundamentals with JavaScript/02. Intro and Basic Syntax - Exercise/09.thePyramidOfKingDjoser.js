function solution(base, increment) {
    let pyramidHeight = 0
    let gold = 0
    let stone = 0
    let marble = 0
    let step = 0
    let lapisLazuli = 0

    for (let i = base; i > 0; i-=2) {
        pyramidHeight++
        step++
        
        //check if we are everywhere but not in the last cycle
        if (i-2 > 0) {
            stone += (i - 2) * (i - 2)
            
            //check if we are on fifth step for lapis lazuli
            if (step % 5 != 0) {
                marble += 2 * (i + i) - 4
            } else if (step % 5 == 0) {
                lapisLazuli += 2 * (i + i) - 4
            }
        }

        //check if we are at the last cycle
        if (i-2 <= 0) {
            gold = i * i
        }
    }
    
    console.log('Stone required: ' + Math.ceil(stone * increment))
    console.log('Marble required: ' + Math.ceil(marble * increment))
    console.log('Lapis Lazuli required: ' + Math.ceil(lapisLazuli * increment))
    console.log('Gold required: ' + Math.ceil(gold * increment))
    console.log('Final pyramid height: ' + Math.floor(pyramidHeight * increment))
}
