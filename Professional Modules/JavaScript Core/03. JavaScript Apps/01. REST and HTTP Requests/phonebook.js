function attachEvents() {
    const URL = 'https://phonebook-nakov.firebaseio.com/phonebook'

    $('#btnLoad').on('click', loadData)
    $('#btnCreate').on('click', postData)

    function loadData() {
        $.ajax({
            method: 'GET',
            url: URL + '.json'
        }).then(handleSuccess)


        function handleSuccess(res) {
            $('#phonebook').empty()
            for (let key in res) {
                let button = $('<button>[Delete]</button>').on('click', delLi)
                let li = $('<li>').text(`${res[key].person}: ${res[key].phone} `).append(button)
                $('#phonebook').append(li)

                function delLi() {
                    $.ajax({
                        method: 'DELETE',
                        url: URL + '/' + key + '.json'
                    }).then(handleSuccess)

                    function handleSuccess() {
                        $(this).parent().remove()
                        loadData()
                    }
                }
            }
        }
    }

    function postData() {
        let person = $('#person').val()
        let phone = $('#phone').val()
        let postData = JSON.stringify({ person, phone })

        $.ajax({
            method: 'POST',
            url: URL + '.json',
            data: postData
        }).then(handleSuccess)

        function handleSuccess(res) {
            loadData()
        }

        $('#person').val('')
        $('#phone').val('')
    }

}