function solution(input) {
    
    for (let row of input) {
        if (row == 'end') break
        let regex = /^[A-Z][a-z ']+:[A-Z ]+$/

        if (regex.test(row)) {
            let [artist, song] = row.split(':')
            let encryptionKey = artist.length
            let artistEncrypted = encrypt(artist, encryptionKey)
            let songEncypted = encrypt(song, encryptionKey)
            console.log('Successful encryption: ' + artistEncrypted + '@' + songEncypted)
        } else {
            console.log('Invalid input!')
        }
    }

    function encrypt(input, encryptionKey) {
        input = input.split('')
        input.map(x => x.charCodeAt()).forEach((e, i) => {
            if (e != 32 && e != 39) {
                let encrytedAscii = e + encryptionKey

                if ((e >= 97 && e <= 122) && encrytedAscii > 122) {
                    encrytedAscii -= 26
                } else if ((e >= 65 && e <= 90) && encrytedAscii > 90) {
                    encrytedAscii -= 26
                }

                input[i] = String.fromCharCode(encrytedAscii)
            }
        })
        return input.join('')
    }
}
