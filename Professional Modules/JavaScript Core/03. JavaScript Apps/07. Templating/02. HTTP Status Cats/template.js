$(() => {
    renderCatTemplate();

    async function renderCatTemplate() {
        let cats = window.cats
        let source = await $.get('./cat-template.hbs')
        let conmpiled = Handlebars.compile(source)
        let template = conmpiled({ cats })
        $('body').append(template)
        $('button').on('click', (ev) => {
            let targetBtn = $(ev.target).text() == 'Show status code' ? $(ev.target).text('Hide status code') :  $(ev.target).text('Show status code')
            let infoDiv = targetBtn.next().toggle()
        })
    }
})
