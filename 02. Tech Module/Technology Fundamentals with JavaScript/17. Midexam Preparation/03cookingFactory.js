function solution(input) {
    let bestBatch = []
    let bestQuality = 0

    for (let i = 0; i < input.length - 1; i++) {
        let currentBatch = input[i].split('#').map(x => +x)
        let currentQuality = currentBatch.reduce((a, b) => a + b, 0)

        if (bestQuality < currentQuality) {
            bestBatch = currentBatch
            bestQuality = currentQuality
        } else if (bestQuality == currentQuality) {

            if (bestQuality / bestBatch.length < currentQuality / currentBatch.length) {
                bestBatch = currentBatch
                bestQuality = currentQuality
            } else if (bestQuality / bestBatch.length == currentQuality / currentBatch.length) {
                if (bestBatch.length > currentBatch.length) {
                    bestBatch = currentBatch
                    bestQuality = currentQuality
                }
            }
        }
    }

    console.log('Best Batch quality: ' + bestQuality)
    console.log(bestBatch.join(' '))
}
solution(['5#4#10#-2', '10#5#2#3#2', '10#5#2#5', 'Bake It!'])
//solution(['5#3#2', '10#2#-2#1#-1', '4#2#1', 'Bake It!'])