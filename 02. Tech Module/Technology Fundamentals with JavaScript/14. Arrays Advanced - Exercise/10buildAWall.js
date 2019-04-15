function solution(input) {
    input = input.map(x => +x)
    let crewWorkCount = 0
    let concrete = []

    while (true) {
        let maxheightCounter = 0
        let dailyCrewWorkCount = 0
        for (let i = 0; i < input.length; i++) {
            if (input[i] < 30) {
                input[i]++
                crewWorkCount++
                dailyCrewWorkCount++
            } else {
                maxheightCounter++
            }
        }
        if (maxheightCounter == input.length) {
            break;
        } else {
            concrete.push(dailyCrewWorkCount * 195)
        }
        
    }
    console.log(concrete.join(', '))
    console.log(crewWorkCount * 195 * 1900 + ' pesos')
}
