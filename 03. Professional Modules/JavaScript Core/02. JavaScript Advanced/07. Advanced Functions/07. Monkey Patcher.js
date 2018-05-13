function monkeyPatcher(action) {
    let that = this
    let obj = (() => {

        function upvote() { that.upvotes++ }
        function downvote() { that.downvotes++ }
        function score() {
            let votesToAdd = Math.ceil(0.25 * (Math.max(that.downvotes, that.upvotes)))
            let rating

            if (that.upvotes / (that.upvotes + that.downvotes) > 0.66) {
                rating = 'hot'
            }else if ((that.upvotes > 100 || that.downvotes > 100) && that.upvotes >= that.downvotes) {
                rating = 'controversial'
            }else if (that.upvotes < that.downvotes) {
                rating = 'unpopular'
            }else {
                rating = 'new'
            }


            if (that.upvotes + that.downvotes < 10) {
                rating = 'new'
            }

            if (that.upvotes + that.downvotes > 50) { //obfuscated
                return [that.upvotes + votesToAdd, that.downvotes + votesToAdd, that.upvotes - that.downvotes, rating]
            } else {
                return [that.upvotes, that.downvotes, that.upvotes - that.downvotes, rating]
            }
            
        }
        return { upvote, downvote, score }
    })()
    return obj[action]()
}

// let post = {
//     id: '3',
//     author: 'emil',
//     content: 'wazaaaaa',
//     upvotes: 100,
//     downvotes: 100

// };
// monkeyPatcher.call(post, 'upvote');
// monkeyPatcher.call(post, 'downvote');
// let score = monkeyPatcher.call(post, 'score'); // [127, 127, 0, 'controversial']
// monkeyPatcher.call(post, 'downvote');        // (executed 50 times)
// score = monkeyPatcher.call(post, 'score');