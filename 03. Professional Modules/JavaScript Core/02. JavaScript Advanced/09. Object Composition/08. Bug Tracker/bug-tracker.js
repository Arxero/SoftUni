function bugTracker() {
    let result = (() => {
        let container = []
        let selector = undefined
        let counter = 0

        let report = function (author, description, reproducible, severity) {
            container[counter] = {
                ID: counter,
                author: author,
                description: description,
                reproducible: reproducible,
                severity: severity,
                status: 'Open'
            }
            counter++
            if (selector) { draw() }
        }

        let setStatus = function (id, newStatus) {
            container[id].status = newStatus
            if (selector) { draw() }
        }

        let remove = function (id) {
            container = container.filter(el => el.ID != id);
            if (selector) { draw() }
        }

        let sort = function (method) {
            switch (method) {
                case 'author':
                    container = container.sort((a, b) => a.author.localeCompare(b.author))
                    break;
                case 'severity':
                    container = container.sort((a, b) => a.severity - b.severity)
                    break;
                default:
                    container = container.sort((a, b) => a.ID - b.ID);
            }
            if (selector) { draw() }
        }

        let output = function (input) {
            selector = input
        }

        let draw = function () {
            $(selector).html('')
            for (let bug of container) {
                $(selector).append($('<div>').attr('id', `report_${bug.ID}`).addClass('report')
                    .append($('<div>').addClass('body')
                        .append($('<p>').text(bug.description)))
                    .append($('<div>').addClass('title')
                        .append($('<span>').addClass('author').text(`Submitted by: ${bug.author}`))
                        .append($('<span>').addClass('status').text(`${bug.status} | ${bug.severity}`))))
            }
        }

        return { report, setStatus, remove, sort, output };
    })()
    return result
}

// let tracker = bugTracker();
// tracker.output('#content');
// tracker.report('guy', 'report content', true, 5);
// tracker.report('second guy', 'report content 2', true, 3);
// tracker.report('abv', 'report content three', true, 4);
// tracker.remove(1);