function attachEvents() {
    const URL = 'https://baas.kinvey.com/appdata/kid_rJMwPo7cf/'
    const USERNAME = 'peter'
    const PASSWORD = 'p'
    const BASE_64 = btoa(USERNAME + ':' + PASSWORD)
    const AUTH = { 'Authorization': 'Basic ' + BASE_64 }
    let postBody = {}

    $('#btnLoadPosts').on('click', loadPosts)
    $('#btnViewPost').on('click', loadComments)

    function loadPosts() {
        $.ajax({
            method: 'GET',
            url: URL + 'posts',
            headers: AUTH
        }).then(handleSuccess)

        function handleSuccess(res) {
            $('#posts').empty()
            for (let row of res) {
                $('#posts').append($('<option>').val(row._id).text(`${row.title}`))
                postBody[row._id] = row.body
            }

        }
    }

    function loadComments() {
        let selectedPost = $('#posts').find('option:selected')

        $.ajax({
            method: 'GET',
            url: URL + `comments/?query={"post_id":"${selectedPost.val()}"}`,
            headers: AUTH
        }).then(handleSuccess)

        function handleSuccess(res) {
            $('#post-title').empty()
            $('#post-body').empty()
            $('#post-comments').empty()
            $('#post-title').text(selectedPost.text())
            $('#post-body').text(postBody[selectedPost.val()])
            
            for (let row of res) {
                $('#post-comments').append($('<li>').text(row.text))
            }
        }
    }
}