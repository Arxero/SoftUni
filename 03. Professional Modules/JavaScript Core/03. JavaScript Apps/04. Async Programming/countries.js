function attachEvents() {
    const URL = 'https://baas.kinvey.com/appdata/kid_rkPbo1FcG/'
    const USERNAME = 'guest'
    const PASSWORD = 'guest'
    const BASE_64 = btoa(USERNAME + ':' + PASSWORD)
    const AUTH = { 'Authorization': 'Basic ' + BASE_64, "Content-type": "application/json" }
    let isCountries = false

    $('#btnCountriesList').on('click', listCountries)
    $('#btnCountriesEdit').on('click', editCountries)


    function listCountries() {
        $('#countries').show()
        isCountries = true

        $.ajax({
            method: 'GET',
            url: URL + 'Country',
            headers: AUTH
        }).then(handleSuccess)

        function handleSuccess(res) {
            $('#countries table tr').each((i, e) => {
                if (i > 0) {
                    e.remove()
                }
            })

            for (let country of res) {
                $('#countries table').append($('<tr>').append($('<td>').text(country.name).attr('id', `${country._id}`)))
            }
        }
    }

    function editCountries() {
        // if (!isCountries) {
        //     $.ajax({
        //         method: 'GET',
        //         url: URL + 'Town',
        //         headers: AUTH
        //     }).then(handleSuccess)

        //     function handleSuccess(res) {
        //         for (let country of res) {
        //             $('#countries table').append($('<tr>').append($('<td>').text(country.country)))
        //         }
        //     }
        // }

        $('#countries table tr').first().find('th').each((i, e) => {
            if (e.textContent == 'Action') {
                e.remove()
            }
        })
        $('#countries table tr').first().append($('<th>').text('Action'))

        $('#countries table tr td').each((i, e) => {
            if (e.textContent == 'Edit') {
                e.remove()
            }
        })
        $('#countries table tr').each((i, e) => {
            if (i > 0) {
                $(e).append($('<td>').append($('<a href="#">Edit</a>').on('click', edit)))
            }
        })

        function edit() {
            let country = $(this).parent().parent().find('td').first().text()
            let input = $(`<input type="text" value="${country}">`).on('input', getEdited)
            $(this).parent().parent().find('td').first().html(input)
            $(this).text('Save').on('click', save)
            let edited = ''
            let id =  $(this).parent().parent().find('td').first().attr('id')

            function getEdited() {
                edited = $(this).parent().parent().find('td input').val()
            }

            function save() {
                $(this).parent().parent().find('td').first().text(edited)
                $(this).text('Edit')
                
                $.ajax({
                    method: 'PUT',
                    url : URL + `Country/${id}`,
                    headers: AUTH,
                    data: JSON.stringify({'name': edited})
                }).then(handleSuccess)
            }

            function handleSuccess(res) {
                listCountries()
            }
        }
    }
}