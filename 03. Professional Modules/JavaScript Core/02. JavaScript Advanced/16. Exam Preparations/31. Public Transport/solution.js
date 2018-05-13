class PublicTransportTable {
    constructor(town) {
        this.town = town
    }

    set town(t) {
        return $('body').find('caption').text(`${t}'s Public Transport`)
    }

    addVehicle(obj) {
        let isClicked = false
        let tr = $('.vehicles-info').append($('<tr>').addClass('hide-info')
            .append($('<td>').text(obj.type))
            .append($('<td>').text(obj.name))
            .append($('<td>')
                .append($('<button>').text('More Info').on('click', function () {
                    $(this).text('Less Info')
                    if (isClicked) {
                        $(this).text('More Info')
                        $(this).parent().parent().parent().find('.more-info').remove()
                    } else {
                        $(this).parent().parent().parent().find('.more-info').remove()
                        $(this).parent().parent().parent().append($('<tr>').addClass('more-info')
                            .append($('<td>').attr('colspan', "3")
                                .append($('<table>')
                                    .append($('<tr>').append($('<td>').text(`Route: ${obj.route}`)))
                                    .append($('<tr>').append($('<td>').text(`Price: ${obj.price}`)))
                                    .append($('<tr>').append($('<td>').text(`Driver: ${obj.driver}`)))
                                )//end of table
                            )//end of td colspan
                        )//end of tr
                        isClicked = false
                    }
                    isClicked = true

                }))
            )//end of last td
        )//end of tr
        return tr
    }
}