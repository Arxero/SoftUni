function extractText() {
    let input = $('#items li').toArray().map(x => x.textContent).join(', ');
    $('#result').text(input);
}