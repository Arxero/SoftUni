function attachEvents() {
    const URL = 'https://baas.kinvey.com/appdata/kid_BJXTsSi-e/students'
    const USERNAME = 'guest'
    const PASSWORD = 'guest'
    const BASE_64 = btoa(USERNAME + ':' + PASSWORD)
    const AUTH = { 'Authorization': 'Basic ' + BASE_64, "Content-type": "application/json" }

    $('body table').hide()
    $('body').append($('<button>').text('Add Student').on('click', () => $('body form').show()))
    $('body').append($('<button>').text('Show Students').on('click', showStudents))

    let form = $(`
    <form>
    ID:<br>
    <input type="number" name="id">
    <br>
    First Name:<br>
    <input type="text" name="firstName">
    <br>
    Last name:<br>
    <input type="text" name="lastName">
    <br>
    Faculty Number:<br>
    <input type="text" name="facultyNumber">
    <br>
    Grade:<br>
    <input type="number" name="grade">
    <br>
    <br>
  </form> `)
    form.append($('<button>').text('Add Student').attr('type', 'button').on('click', addStudent))
    form.append($('<button>').text('Hide').attr('type', 'button').on('click', () => $('body form').hide()))
    $('body').append($(form))
    $('body form').hide()

    function addStudent() {
        let ID = Number($('body form').find('[name=id]').val())
        let FirstName = $('body form').find('[name=firstName]').val()
        let LastName = $('body form').find('[name=lastName]').val()
        let FacultyNumber = $('body form').find('[name=facultyNumber]').val()
        let Grade = Number($('body form').find('[name=grade]').val())

        if (ID != 0 && FirstName != '' && LastName != '' && FacultyNumber != '' && Grade != 0) {
            $.ajax({
                method: 'POST',
                url: URL,
                headers: AUTH,
                data: JSON.stringify({ ID, FirstName, LastName, FacultyNumber, Grade })
            }).then(handleSuccess)

            function handleSuccess(res) {
                $('body form').find('[name=id]').val('')
                $('body form').find('[name=firstName]').val('')
                $('body form').find('[name=lastName]').val('')
                $('body form').find('[name=facultyNumber]').val('')
                $('body form').find('[name=grade]').val('')
            }
        }
    }

    function showStudents() {
        $('body table').show()
        $('body form').hide()

        $.ajax({
            method: 'GET',
            url: URL,
            headers: AUTH
        }).then(handleSuccess)

        function handleSuccess(res) {
            res.sort((a, b) => a.ID - b.ID)
            
            for (let student of res) {
                $('#results').append($('<tr>')
                    .append($('<td>').text(student.ID))
                    .append($('<td>').text(student.FirstName))
                    .append($('<td>').text(student.LastName))
                    .append($('<td>').text(student.FacultyNumber))
                    .append($('<td>').text(student.Grade)))
            }
        }
    }
}