function attachEvents() {
    const URL = 'https://judgetests.firebaseio.com/'
    let location = $('#location')
    $('#submit').on('click', getWeather)

    function getWeather() {
        $.ajax({
            method: 'GET',
            url: URL + 'locations.json'
        }).then(handleSuccess)
            .catch(handleError)

        function handleSuccess(res) {
            let code = res.filter(x => x.name == location.val())[0].code
            $('#forecast').css('display', 'block')
            if ($('#current .label').text() == "Error") {
                $('#current .label').text('Current conditions')
                $('#upcoming').append($('<div>').addClass('label').text('Three-day forecast'))
            }

            let symbol = {
                'Sunny': '&#x2600',
                'Partly sunny': '&#x26C5',
                'Overcast': '&#x2601',
                'Rain': '&#x2614',
                'Degrees': '&#176'
            }

            $.ajax({
                method: 'GET',
                url: URL + `forecast/today/${code}.json`
            }).then(handleSuccess1)

            function handleSuccess1(res) {
                let condition = res.forecast.condition
                $('#current .condition symbol').empty()
                $('#current .condition').empty()
                $('#current').append($('<span>').addClass('condition symbol').html(symbol[condition]))
                    .append($('<span>').addClass('condition')
                        .append($('<span>').addClass('forecast-data').text(res.name))
                        .append($('<span>').addClass('forecast-data').html(`${res.forecast.low}${symbol['Degrees']}/${res.forecast.high}${symbol['Degrees']}`))
                        .append($('<span>').addClass('forecast-data').text(condition)))
            }

            $.ajax({
                method: 'GET',
                url: URL + `forecast/upcoming/${code}.json`
            }).then(handleSuccess2)

            function handleSuccess2(res) {
                $('#upcoming .upcoming').remove()
                for (let day of res.forecast) {
                    let condition = day.condition
                    $('#upcoming').append($('<span>').addClass('upcoming')
                        .append($('<span>').addClass('symbol').html(symbol[condition]))
                        .append($('<span>').addClass('forecast-data').html(`${day.low}${symbol['Degrees']}/${day.high}${symbol['Degrees']}`))
                        .append($('<span>').addClass('forecast-data').text(day['condition'])
                        ))
                }
            }
        }

        function handleError(err) {
            $('#forecast').css('display', 'block')
            $('#current .label').text('Error')
            $('#upcoming').empty()
            $('#current .condition symbol').empty()
            $('#current .condition').empty()
        }
    }
}