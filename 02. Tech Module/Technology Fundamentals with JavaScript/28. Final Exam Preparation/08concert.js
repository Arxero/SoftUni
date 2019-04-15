function solution(input) {
    let IndexOfStart = input.indexOf('start of concert')
    let finalBandName = input.pop()
    input = input.slice(0, IndexOfStart)
    let bandsWithTimes = {}
    let bandsWithMembers = {}
    let totalTime = 0

    for (let row of input) {
        if (row.startsWith('Add')) {
            let [bandName, members] = row.substring(5).split('; ')

            if (!bandsWithMembers.hasOwnProperty(bandName)) {
                bandsWithMembers[bandName] = members.split(', ')
            } else {
                let currentMembers = bandsWithMembers[bandName]
                let newMembers = members.split(', ')

                newMembers.forEach(x => {
                    if (!currentMembers.includes(x)) {
                        currentMembers.push(x)
                    }
                })

                bandsWithMembers[bandName] = currentMembers
            }
        } else {
            let [bandName, time] = row.substring(6).split('; ')
            totalTime += +time

            if (!bandsWithTimes.hasOwnProperty(bandName)) {
                bandsWithTimes[bandName] = +time
            } else {
                let currentBandTime = bandsWithTimes[bandName]
                bandsWithTimes[bandName] = currentBandTime + +time
            }
        }
    }


    let sorted = Object.entries(bandsWithTimes).sort((a, b) => {
        if (a[1] < b[1]) {
            return 1
        } else if (a[1] == b[1]) {
            return a[0].localeCompare(b[0])
        }
    })

    console.log('Total time: ' + totalTime)
    sorted.forEach(x => {
        console.log(x[0] + ' -> ' + x[1])
    })

    console.log(finalBandName)
    bandsWithMembers[finalBandName].forEach(x => console.log('=> ' + x))
}
