function getInfo() {
    // let axios = require('axios')
    // let fs = require('fs')
    // axios.get('http://www.gametracker.rs/server_info/93.123.18.81:27017/')
    //     .then(function (response) {
    //         let html = response.data
    //         fs.writeFileSync('test.html', html)
    //     })
    // //console.log(obj);
    let $ = require('jQuery');
    const jsdom = require("jsdom");
    const { JSDOM } = jsdom;

    //let jsdom = require('jsdom-global')()
    let axios = require('axios')
    var name = "codemzy";
    $.get('http://www.gametracker.rs/server_info/93.123.18.81:27017/' + name, function (response) {
        console.log(response);
    });




    //let a = $('#content')
    //console.log(a);



}
getInfo()

