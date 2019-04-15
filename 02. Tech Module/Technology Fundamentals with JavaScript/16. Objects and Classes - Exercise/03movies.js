function solution(input) {
    let movies = []

    for (let i = 0; i < input.length; i++) {
        let inputLine = input[i].split(' ')

        if (inputLine[0] == 'add') {
            let movieAdd = inputLine.slice(2).join(' ')
            movies.push({ name: movieAdd })
        } else if (inputLine.includes('directed')) {
            let indexOfDirected = inputLine.indexOf('directed')
            let movieDirected = inputLine.slice(0, indexOfDirected).join(' ')
            let movieDirector = inputLine.slice(indexOfDirected + 2).join(' ')
            inputLine.splice(indexOfDirected, 2)

            for (const key in movies) {
                if (movies[key].name == movieDirected) {
                    Object.assign(movies[key], { 'director': movieDirector })
                }
            }
        } else if (inputLine.includes('date')) {
            let indexOfDate = inputLine.indexOf('date')
            let movieDate = inputLine.slice(0, indexOfDate - 1).join(' ')
            let movieTheDate = inputLine.slice(indexOfDate + 1).join(' ')

            for (const key in movies) {
                if (movies[key].name == movieDate) {
                    Object.assign(movies[key], { 'date': movieTheDate })
                }
            }
        }

    }

    for (let movie of movies) {
        if (movie.hasOwnProperty('name') && movie.hasOwnProperty('director') && movie.hasOwnProperty('date')) {
            let ordered = {}
            Object.keys(movie).sort((a, b) => a < b).forEach(x => ordered[x] = movie[x])
            console.log(JSON.stringify(ordered))
        }
    }
}
