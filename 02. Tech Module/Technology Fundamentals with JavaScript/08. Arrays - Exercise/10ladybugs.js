function solution(input) {
    let fieldSize = input.shift()
    let initialLadybugPlacement = input.shift().split(' ').map(x => +x)
    let initialField = []

    //creating the initial field
    for (let i = 0; i < fieldSize; i++) {
        initialField.push(0)
    }
    for (let i = 0; i < initialLadybugPlacement.length; i++) {
        //checking if bug placment is within the fieldsize
        if (initialLadybugPlacement[i] >= 0 && initialLadybugPlacement[i] <= fieldSize) {
            initialField[initialLadybugPlacement[i]] = 1
        }
        
        
    }
    //console.log(initialField)


    //creating the flying part
    for (let i = 0; i < input.length; i++) {
        let bugIndex = +input[i].split(' ')[0]
        let direction = input[i].split(' ')[1]
        let flyLength = +input[i].split(' ')[2]
        console.log(flyLength)

        if (direction == 'right') {
            //checking if there is a bug on the given index and if it is in the field range
            if (initialField[bugIndex] == 1 && (bugIndex >= 0 && bugIndex <= initialField.length - 1)) {
                
                for (let j = bugIndex + 1; j <= initialField.length; j++) {
                    if (initialField[j] == 0 && flyLength > 0) {
                        initialField[bugIndex] = 0
                        flyLength--
                        if (flyLength == 0) {
                            initialField[j] = 1
                        }
                    } else if (initialField[j] == 1 || initialField[j] == undefined) {
                        initialField[bugIndex] = 0
                    }
                }
            }
        } else if (direction == 'left') {
            //checking if there is a bug on the given index and if it is in the field range
            if (initialField[bugIndex] == 1 && (bugIndex >= 0 && bugIndex <= initialField.length - 1)) {
                
                for (let k = bugIndex - 1; k >= 0; k--) {
                    if (initialField[k] == 0 && flyLength > 0) {
                        initialField[bugIndex] = 0
                        flyLength--
                        if (flyLength == 0) {
                            initialField[k] = 1
                        }
                    } else if (initialField[k] == 1 || initialField[k] == undefined) {
                        initialField[bugIndex] = 0
                    }
                } 
            }
        }

    }
    console.log(initialField.join(' '))

}
//solution([3, '0 1', '0 right 1', '2 right 1'])
//solution([ 3, '0 1 2', '0 right 1', '1 right 1', '2 right 1'])
solution([ 5, '3', '3 left 2', '1 left -2'])
//solution([3, '0', '0 right 2'])
