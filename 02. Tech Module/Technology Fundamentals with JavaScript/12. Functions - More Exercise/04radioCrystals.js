function solution(input) {
    let desiredThickness = input.shift()

    for (let chunk of input) {
        console.log(`Processing chunk ${chunk} microns`)

        //cut
        if (chunk / 4 >= desiredThickness) {
            let cutCount = 0
            while (chunk / 4 >= desiredThickness) {
                chunk /= 4
                cutCount++
            }
            console.log('Cut x' + cutCount)
            chunk = transportAndWash(chunk)
        }

        //lap
        if (chunk - (20 / 100 * chunk) >= desiredThickness) {
            let lapCount = 0
            while (chunk - (20 / 100 * chunk) >= desiredThickness) {
                chunk -= (20 / 100 * chunk)
                lapCount++
            }
            console.log('Lap x' + lapCount)
            chunk = transportAndWash(chunk)
        }

        //grind
        if (chunk - 20 >= desiredThickness) {
            let grindCount = 0
            while (chunk - 20 >= desiredThickness) {
                chunk -= 20
                grindCount++
            }
            console.log('Grind x' + grindCount)
            chunk = transportAndWash(chunk)
        }

        //etch
        if (chunk > desiredThickness) {
            let etchCount = 0
            while (chunk - 2 >= desiredThickness) {
                chunk -= 2
                etchCount++
            }
            if (chunk - 1 == desiredThickness) {
                chunk -= 2
                etchCount++
            }
            console.log('Etch x' + etchCount)
            chunk = transportAndWash(chunk)
        }

        //xray
        if (chunk < desiredThickness) {
            let xrayCount = 0
            while (chunk + 1 == desiredThickness) {
                chunk++
                xrayCount++
            }
            console.log('X-ray x' + xrayCount)
        }

        console.log(`Finished crystal ${chunk} microns`)
    }

    function transportAndWash(chunk) {
        console.log('Transporting and washing')
        return Math.floor(chunk)
    }
}
