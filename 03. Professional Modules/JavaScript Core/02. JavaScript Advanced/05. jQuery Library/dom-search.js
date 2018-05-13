function domSearch(selector, isCaseSensitive) {
    let addControls = $(selector)
    .append($('<div>').addClass('add-controls')
    .append($('<label>').text('Enter text:')
    .append($('<input>')))
    .append($('<a>').addClass('button').text('Add').css('display', 'inline-block')
    .on('click', add)))
    
    let searchControls = $(selector)
    .append($('<div>').addClass('search-controls')
    .append($('<label>').text('Search:')
    .append($('<input>').on('input', search))))

    let resultControls = $(selector)
    .append($('<div>').addClass('result-controls')
    .append($('<ul>').addClass('items-list')))

    function add() {
        let text = $('.add-controls label input').val()
        let list = $('<li>').addClass('list-item')
        .append($('<a>').addClass('button').text('X').on('click', deleting))
        .append($('<strong>').text(text))
        $('.items-list').append(list)
        $('.add-controls label input').val('')
    }

    function search() {
        let text = $(this).val()
        $('.list-item').each((index, li) => matches(li, text))
    }

    function deleting() {
        $(this).parent().remove()
    }
    
    function matches(li, text) {
        $(li).css('display', 'inline-block')
        if (isCaseSensitive) {
            if ($(li).find('strong').text().indexOf(text) == -1) {
                $(li).css('display', 'none')
            }
        }else {
            if ($(li).find('strong').text().toLowerCase().indexOf(text.toLowerCase()) == -1) {
                $(li).css('display', 'none')
            }
        }
    }
}