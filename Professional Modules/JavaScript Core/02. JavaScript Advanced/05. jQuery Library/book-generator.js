function createBook(selector, title, author, isbn) {
    let id = 1
    let a = $(selector).append($('<div>').attr('id', `book${id}`)
        .append($('<p>').addClass('title').text(`${title}`))
        .append($('<p>').addClass('author').text(`${author}`))
        .append($('<p>').addClass('isbn').text(`${isbn}`))
        .append($('<button>').text('Select').on('click', select))
        .append($('<button>').text('Deselect').on('click', deselect))
    )

    function select() {
        $(this).parent().css('border', '2px solid blue')
    }

    function deselect() {
        $(this).parent().css('border', 'none')
    }
    id++
}