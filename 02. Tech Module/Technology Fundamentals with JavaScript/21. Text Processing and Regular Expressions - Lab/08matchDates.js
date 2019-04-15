function solution(input) {
    let regexPattern = /\b(?<day>[0-9]{2})(\.|\/|-)(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b/g
    
    while ((validDate = regexPattern.exec(input[0])) !== null) {
        let day = validDate.groups['day']
        let month = validDate.groups['month']
        let year = validDate.groups['year']
        console.log(`Day: ${day}, Month: ${month}, Year: ${year}`)
    }
}
