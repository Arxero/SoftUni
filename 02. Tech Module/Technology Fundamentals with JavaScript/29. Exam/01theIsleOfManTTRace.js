function solution(input) {
    let regex = /^(#|\$|%|&|\*)(?<racer>[a-zA-Z]+)\1=(?<geohashLength>[0-9]+)!!(?<geohashCode>.+)$/

    for (let row of input) {
        if (regex.test(row)) {
            let match = row.match(regex)
            let hashCode = match.groups.geohashCode

            if (match.groups.geohashLength == hashCode.length) {
                hashCode = hashCode.split('')
                    .map(x => x.charCodeAt() + hashCode.length)
                    .map(x => String.fromCharCode(x))
                    .join('')

                console.log(`Coordinates found! ${match.groups.racer} -> ${hashCode}`)
                return
            } else {
                console.log('Nothing found!')
            }
        } else {
            console.log('Nothing found!')
        }
    }
}
// solution(['%GiacomoAgostini%=7!!hbqw',
//     '&GeoffDuke*=6!!vjh]zi',
//     'JoeyDunlop=10!!lkd,rwazdr',
//     'Mike??Hailwood=5!![pliu',
//     '#SteveHislop#=16!!df%TU[Tj(h!!TT[S']
// )

solution(['Ian6Hutchinson=7!!\\(58ycb4',
    '#MikeHailwood#!!\'gfzxgu6768=11',
    'slop%16!!plkdek/.8x11ddkc',
    '$Steve$=9Hhffjh',
    '*DavMolyneux*=15!!efgk#\'_$&UYV%h%',
    'RichardQ^uayle=16!!fr5de5kd']
)