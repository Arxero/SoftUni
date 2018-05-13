function attachEvents() {
    const URL = 'https://baas.kinvey.com/appdata/kid_B1JkD_D9M/'
    const USERNAME = 'Fisher'
    const PASSWORD = 'Fisher'
    const BASE_64 = btoa(USERNAME + ':' + PASSWORD)
    const AUTH = { 'Authorization': 'Basic ' + BASE_64, "Content-type": "application/json" }

    $('#aside .load').on('click', loadData)
    $('#aside .add').on('click', addData)
    $('#catches .delete').on('click', function () {
        $(this).parent().parent().hide()
    })

    function loadData() {
        $.ajax({
            method: 'GET',
            url: URL + 'biggestCatches',
            headers: AUTH
        }).then(handleSuccess)

        function handleSuccess(res) {
            $('.catch').remove()
            $('#catches').show()
            for (let caatch of res) {
                let element = $('#catches').append($(`<div class="catch" data-id="${caatch._id}">
                <label>Angler</label>
                <input type="text" class="angler" value="${caatch.angler}">
                <label>Weight</label>
                <input type="number" class="weight" value="${caatch.weight}">
                <label>Species</label>
                <input type="text" class="species" value="${caatch.species}">
                <label>Location</label>
                <input type="text" class="location" value="${caatch.location}">
                <label>Bait</label>
                <input type="text" class="bait" value="${caatch.bait}">
                <label>Capture Time</label>
                <input type="number" class="captureTime" value="${caatch.captureTime}">
            </div>`).append($('<button>').addClass('update').text('Update').on('click', updateData))
                    .append($('<button>').addClass('delete').text('Delete').on('click', deleteData)))
            }
        }
    }

    function addData() {
        let angler = $('#addForm .angler').val()
        let weight = Number($('#addForm .weight').val())
        let species = $('#addForm .species').val()
        let location = $('#addForm .location').val()
        let bait = $('#addForm .bait').val()
        let captureTime = Number($('#addForm .captureTime').val())

        $.ajax({
            method: 'POST',
            url: URL + 'biggestCatches',
            headers: AUTH,
            data: JSON.stringify({ angler, weight, species, location, bait, captureTime })
        }).then(handleSuccess)


        function handleSuccess(res) {
            $('#addForm .angler').val('')
            $('#addForm .weight').val('')
            $('#addForm .species').val('')
            $('#addForm .location').val('')
            $('#addForm .bait').val('')
            $('#addForm .captureTime').val('')
            loadData()
        }
    }


    function updateData() {
        let id = $(this).parent().attr('data-id')
        let angler = $(this).parent().find('.angler').val()
        let weight = Number($(this).parent().find('.weight').val())
        let species = $(this).parent().find('.species').val()
        let location = $(this).parent().find('.location').val()
        let bait = $(this).parent().find('.bait').val()
        let captureTime = Number($(this).parent().find('.captureTime').val())

        $.ajax({
            method: 'PUT',
            url: URL + `biggestCatches/${id}`,
            headers: AUTH,
            data: JSON.stringify({ angler, weight, species, location, bait, captureTime })
        }).then(() => loadData())
    }

    function deleteData() {
        let id = $(this).parent().attr('data-id')
        $.ajax({
            method: 'DELETE',
            url: URL + `biggestCatches/${id}`,
            headers: AUTH,
        }).then(() => loadData())
    }
}