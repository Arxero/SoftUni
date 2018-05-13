function timer() {
    let time = 0
    let interval
    let isRunning = false

    $('#start-timer').on('click', start)
    $('#stop-timer').on('click', stop)

    function start() {
        if (isRunning == false) {
            interval = setInterval(incrementTime, 1000)
            isRunning = true
        }
    }

    function stop() {
        clearInterval(interval)
        isRunning = false

    }

    function incrementTime() {
        time++
        $('#seconds').text(`${('0' + Math.trunc(time % 60)).slice(-2)}`)
        $('#minutes').text(`${('0' + Math.trunc((time / 60) % 60)).slice(-2)}`)
        $('#hours').text(`${('0' + Math.trunc(time / 3600)).slice(-2)}`)

    }
}