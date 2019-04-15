function solution(input) {
    class Song {
        constructor(typeList, name, time) {
            this.typeList = typeList
            this.name = name
            this.time = time
        }
    }

    let songs = []
    let numberOfSongs = input.shift()
    let typeSong = input.pop()

    for (let i = 0; i < numberOfSongs; i++) {
        let songLine = input[i].split('_')
        let typeList = songLine[0]
        let name = songLine[1]
        let time = songLine[2]
        let song = new Song(typeList, name, time)
        songs.push(song)
    }

    if (typeSong == 'all') {
        songs.forEach(x => console.log(x.name))
    } else {
        songs.filter(x => x.typeList == typeSong).forEach(x => console.log(x.name))
    }
}
