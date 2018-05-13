class MailBox {
    constructor() {
        this.box = []
    }

    addMessage(subject, text) {
        this.box.push({ subject, text })
        return this
    }

    get messageCount() {
        return this.box.length
    }

    deleteAllMessages() {
        return this.box = []
    }

    findBySubject(substr) {
         return this.box.filter(
            m => m.subject.includes(substr));
    }

    toString(){
        if (this.box.length == 0) {
            return '* (empty mailbox)'
        }else {
            let messages = ``
            for (let i = 0; i < this.box.length; i++) {
                messages += ` * [${this.box[i].subject}] ${this.box[i].text}`
                if (i < this.box.length - 1) {
                    messages += '\n'
                }
            }
            return messages
        }
    }
}

// let mb = new MailBox();
// console.log("Msg count: " + mb.messageCount);
// console.log('Messages:\n' + mb);
// mb.addMessage("meeting", "Let's meet at 17/11");
// mb.addMessage("beer", "Wanna drink beer tomorrow?");
// mb.addMessage("question", "How to solve this problem?");
// mb.addMessage("Sofia next week", "I am in Sofia next week.");
//console.log(mb);


//console.log("Msg count: " + mb.messageCount);
//console.log('Messages:\n' + mb);
// console.log("Messages holding 'rakiya': " +
//     JSON.stringify(mb.findBySubject('rakiya')));
// console.log("Messages holding 'ee': " +
//     JSON.stringify(mb.findBySubject('ee')));

// mb.deleteAllMessages();
// console.log("Msg count: " + mb.messageCount);
// console.log('Messages:\n' + mb);

// console.log("New mailbox:\n" +
//     new MailBox()
//         .addMessage("Subj 1", "Msg 1")
//         .addMessage("Subj 2", "Msg 2")
//         .addMessage("Subj 3", "Msg 3")
//         .toString());