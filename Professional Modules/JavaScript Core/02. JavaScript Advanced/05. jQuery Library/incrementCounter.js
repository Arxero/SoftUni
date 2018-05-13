function increment(input) {
    let selector = $(input)
    let textarea = $('<textarea>').addClass('counter').val('0').attr('disabled', true).appendTo($(selector))
    let incrementBtn = $('<button>').addClass('btn').attr('id', 'incrementBtn').text('Increment').appendTo($(selector)).on('click', incrementV)
    let addBtn = $('<button>').addClass('btn').attr('id', 'addBtn').text('Add').appendTo($(selector)).on('click', add)
    let ul = $('<ul>').addClass('results').appendTo(selector)

    function incrementV() {
        textarea.val(Number(textarea.val()) + 1)
        console.log(selector[0]);
    }

    function add() {
        ul.append($('<li>').text(textarea.val()))
        console.log(selector[0]);
    }
}