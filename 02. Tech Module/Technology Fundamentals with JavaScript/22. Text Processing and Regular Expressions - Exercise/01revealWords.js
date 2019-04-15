function solution(input, template) {
    input = input.split(', ')
    template = template.split(' ')

    for (let i = 0; i < input.length; i++) {
        let currentWord = input[i]
        
        for (let k = 0; k < template.length; k++) {
            let currentTemplateWord = template[k]
            
            if (currentWord.length == currentTemplateWord.length && currentTemplateWord == '*'.repeat(currentWord.length)) {
                template.splice(k, 1, currentWord)
            }
        }  
    }

    console.log(template.join(' '))
}