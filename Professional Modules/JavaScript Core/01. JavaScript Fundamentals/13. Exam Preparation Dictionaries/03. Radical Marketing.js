function solution(input) {
    //console.log(new Date().toString())
    let people = new Map()
    let subs = new Map()

    for (let row of input) {
        let splitter = row.split('-')
        let person = splitter[0]

        if (splitter.length == 1) {
            if (!people.has(person)) {
                people.set(person, new Set())
                subs.set(person, new Set())
            }
        } else if (splitter.length == 2) {
            let subscriber = splitter[1]
            if (people.has(person) && people.has(subscriber)) {
                people.get(subscriber).add(person)
                subs.get(person).add(subscriber)
            }
        }
    }

    let sortedPeople = new Map([...people.entries()].sort((a, b) => {
        let firstEntryName = a[0]
        let secondEntryName = b[0]
        let aSize = a[1].size
        let bSize = b[1].size
        let result = bSize - aSize
        
        if(result == 0) {
            let firstEntrySubscriptions = subs.get(firstEntryName).size;
            let secondEntrySubscriptions = subs.get(secondEntryName).size;

            result = secondEntrySubscriptions - firstEntrySubscriptions;
        }
        return result
    }))

    let mostImportantPerson = [...sortedPeople.entries()][0];
    console.log(mostImportantPerson[0]);

    let count = 1;
    mostImportantPerson[1].forEach(function(e){
        console.log(count + ". " + e);
        count++;
    });
}

solution([
    'A',
    'B',
    'C',
    'D',
    'A-B',
    'B-A',
    'C-A',
    'D-A'
])

// console.log(solution([
//     'J',
//     'G',
//     'P',
//     'R',
//     'C',
//     'J-G',
//     'G-J',
//     'P-R',
//     'R-P',
//     'C-J'
// ]));
