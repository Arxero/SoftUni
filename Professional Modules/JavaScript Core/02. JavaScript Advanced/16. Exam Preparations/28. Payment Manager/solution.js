class PaymentManager {
    constructor(title) {
        this.element = this.createElement(title)
    }

    createElement(title) {
        let table = $('<table>')
            .append($('<caption>').text(`${title} Payment Manager`))
            .append($('<thead>')
                .append($('<tr>')
                    .append($('<th>').addClass('name').text('Name'))
                    .append($('<th>').addClass('category').text('Category'))
                    .append($('<th>').addClass('price').text('Price'))
                    .append($('<th>').text('Actions'))
                )//end of tr
            )//end of thead
            .append($('<tbody>').addClass('payments')

            )//end of tbody
            .append($('<tfoot>').addClass('input-data')
                .append($('<tr>')
                    .append($('<td>').append($('<input>').attr('name', 'name').attr('type', 'text')))
                    .append($('<td>').append($('<input>').attr('name', 'category').attr('type', 'text')))
                    .append($('<td>').append($('<input>').attr('name', 'price').attr('type', 'number')))
                    .append($('<td>')
                        .append($('<button>').text('Add').on('click', function () {
                            
                            let name = $(this).parent().parent().find('input[name=name]').val()
                            let category = $(this).parent().parent().find('input[name=category]').val()
                            let price = $(this).parent().parent().find('input[name=price]').val()

                            if (name.length > 0 && category.length > 0 && price.length > 0) {
                                $(this).parent().parent().parent().parent().find('tbody').append($('<tr>')
                                    .append($('<td>').text(name))
                                    .append($('<td>').text(category))
                                    .append($('<td>').text(Math.round(Number(price) * 100000) / 100000))
                                    .append($('<td>')
                                        .append($('<button>').text('Delete').on('click', function () {
                                            $(this).parent().parent().remove()
                                        }))
                                    )//end of delete td
                                )
                            }

                            $(this).parent().parent().find('input[name=name]').val('')
                            $(this).parent().parent().find('input[name=category]').val('')
                            $(this).parent().parent().find('input[name=price]').val('')
                        }))
                    )//end of add td
                )//end of tr tfoot
            )//end of tfoot
        return table
    }

    render(id) {
        $(`#${id}`).append($(this.element))
    }
}