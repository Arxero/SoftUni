function search() {
    let input = $('#searchText').val();
    let count = 0;
    let towns = $('#towns li').toArray()
    for (let town of towns) {
        if (town.textContent.includes(input)) {
            $(town).css('font-weight', 'bold');
            count++;
        }
    }
    $('#result').text(count + ' matches found.')
    $('#searchText').val('')
}