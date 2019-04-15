function solution(input) {
    let singlePartLength = input.length / 3
    let initialLength = input.length
    let base = []
    let middle = []
    let top = []

    for (let i = 0; i < initialLength; i++) {
        for (let k = 0; k < singlePartLength; k++) {
            if (base.length < singlePartLength) {
                base.push(input.shift())
            } else if (middle.length < singlePartLength) {
                middle.push(input.shift())
            } else if (top.length < singlePartLength){
                top.push(input.shift())
            }
        }
    }

    base.forEach(x => {
        let basePattern = /^[A-Z]+([0-9]{4,}[A-Z]+)+[0-9]+$/
        if (basePattern.test(x)) {
            console.log('SOLID BASE!')
        } else {
            console.log('WEAK BASE!')
        }
    })

    middle.forEach(x => {
        let middlePattern = /^[a-zA-Z]{3,}[a-zA-Z#@$%]*(#|@|\$|%)$/
        if (middlePattern.test(x)) {
            console.log('SOLID MIDDLE!')
        } else {
            console.log('WEAK MIDDLE!')
        }
    })

    top.forEach(x => {
        let topPattern = /^0+([a-z]{1,5}0+)+[a-z]{1,5}$/
        if (topPattern.test(x)) {
            console.log('SOLID TOP!')
        } else {
            console.log('WEAK TOP!')
        }
    })
}
solution(['SO9000STRONG10000WALL7000',
    'YES345345345PLEASEHAHA999999',
    'xaXAxa###MiDDlE%%$##',
    'mMmMm%%%%ImRichGuy$$$$$',
    '00000cant0do000that',
    '0sorry00happy000sad'
]
)