function solution(input) {
    if (input.handsShaking) {
        let result = (input.weight * 0.1) * input.experience
        input.bloodAlcoholLevel += result
        input.handsShaking = false
        return input
    } else {
        return input

    }
}

// solution(
//     {
//         weight: 80,
//         experience: 1,
//         bloodAlcoholLevel: 0,
//         handsShaking: true
//     }
// )

// solution(
//     {
//         weight: 120,
//         experience: 20,
//         bloodAlcoholLevel: 200,
//         handsShaking: true
//     }
// )