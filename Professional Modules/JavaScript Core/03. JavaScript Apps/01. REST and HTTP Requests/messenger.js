function attachEvents() {
    const URL = 'https://messenger-24972.firebaseio.com/messenger'

    $('#refresh').on('click', refresh)
    $('#submit').on('click', send)

    function refresh() {
        $.ajax({
            method: 'GET',
            url: URL + '.json'
        }).then(handleSuccess)


        function handleSuccess(res) {
            let message = ``
            for (let key in res) {
                message += `${res[key].author}: ${res[key].content}\n`
                $('#messages').text(message)
            }
        }
    }

    function send() {
        let author = $('#author').val()
        let content = $('#content').val()
        let postData = JSON.stringify({ author, content })

        $.ajax({
            method: 'POST',
            url: URL + '.json',
            data: postData
        }).then(handleSuccess)

        function handleSuccess(res) {
            refresh()
        }

        //$('#author').val('')
        $('#content').val('')
    }
}