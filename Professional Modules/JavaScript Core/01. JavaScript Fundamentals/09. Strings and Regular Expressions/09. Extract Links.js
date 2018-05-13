function extract(input) {
    let pattern = /www\.[A-Za-z0-9\-]+(\.[a-z]+)+/g;

    for (let element of input) {
        let match = null;
        while (match = pattern.exec(element)) {
            console.log(match[0]);
        }
    }
}
// extract(['Join WebStars now for free, at www.web-stars.com', 'You can also support our partners:', 'Internet - www.internet.com', 'WebSpiders - www.webspiders101.com', 'Sentinel - www.sentinel.-ko']);