function attachEvents() {
    $('#items li').on('click', function () {
        let li = $(this);
        if (li.attr('data-selected')) {
            li.removeAttr('data-selected');
            li.css('background-color', 'none')
        } else {
            li.attr('data-selected', true);
            li.css('background-color', '#ddd');
        }
    });

    $('#showTownsButton').on('click', function () {
        let selected = $('#items li[data-selected=true]')
        .toArray().map(x => x.textContent).join(', ');
        $('#selectedTowns').text('Selected towns: ' + selected);
    })
}