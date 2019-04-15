function solution(input, names) {
    input = input.split(' ')

    for (let i = 0; i < input.length; i++) {
        let word = input[i]
        
        if (word == 'dwarf' && names.length > 0) {
            input.splice(i + 1, 0, names[0])
            names.shift()
            i += 2
        } else if (word == 'dwarf' && names.length == 0) {
            input.splice(i, 1)
        }
    }

    console.log(input.join(' '))
}
solution('Yet another dwarf fairytale tragedy! There are dwarf so many dwarfs, is it dwarf possible to help dwarf Show white?',
    ["Doc", "Dopey", "Sleepy"])