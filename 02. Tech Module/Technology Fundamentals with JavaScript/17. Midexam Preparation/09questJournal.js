function solution(input) {
    let journal = input.shift().split(', ')

    for (let i = 0; i < input.length - 1; i++) {
        let [command, quest] = input[i].split(' - ')

        switch (command) {
            case 'Start':
                if (!journal.includes(quest)) {
                    journal.push(quest)
                }
                break
            case 'Complete':
                if (journal.includes(quest)) {
                    journal = journal.filter(x => x != quest)
                }
                break
            case 'Side Quest':
                let sideQuest = quest.split(':')[1]
                quest = quest.split(':')[0]

                if (journal.includes(quest) && !journal.includes(sideQuest)) {
                    let indexOfQuestSide = journal.indexOf(quest)
                    journal.splice(indexOfQuestSide + 1, 0, sideQuest)
                }
                break
            case 'Renew':
                if (journal.includes(quest)) {
                    let indexOfQuestRenew = journal.indexOf(quest)
                    journal.splice(indexOfQuestRenew, 1)
                    journal.push(quest)
                }
                break
        }
    }

    console.log(journal.join(', '))
}
