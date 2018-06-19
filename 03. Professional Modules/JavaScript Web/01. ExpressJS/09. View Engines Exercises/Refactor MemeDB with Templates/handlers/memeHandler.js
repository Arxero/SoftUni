const Genre = require('../models/Genre')
const Meme = require('../models/Meme')
const seedMemes = require('../db/memedb')

module.exports.addMemeGet = (req, res) => {
    Genre.find().then((genres) => {

        let content = ''
        for (let genre of genres) {
            content += `<option value="${genre.genreName}">${genre.genreName}</option>`
        }
        res.render('addMeme', { content })
    })
}

module.exports.addMemePost = (req, res) => {
    let memeGenre = req.body.genreSelect
    let memeImage = req.body.image
    memeImage = '\\' + req.file.path

    let meme = {
        title: req.body.memeTitle,
        description: req.body.memeDescription,
        image: memeImage,
        privacy: req.body.status
    }
    Meme.create(meme).then((meme) => {
        Genre.findOne({ genreName: memeGenre }).then((genre) => {
            genre.memeList.push(meme._id)
            genre.save()

            if (genre.genreName != 'ALL') {
                Genre.findOne({ genreName: 'ALL' }).then((genreAll) => {
                    genreAll.memeList.push(meme._id)
                    genreAll.save()
                })
            }
            res.redirect('/viewAllMemes')
        })

    })

}

module.exports.viewAllGet = (req, res) => {
    Genre.find().then((genres) => {
        if (genres.length == 0) {
            let seedGenres = [
                { genreName: 'RickAndMorty' },
                { genreName: 'NotRickAndMorty' }]

            Genre.create(seedGenres).then(() => {
                Meme.create(seedMemes).then((memes) => {
                    Genre.findOne({ genreName: 'RickAndMorty' }).then((genre) => {
                        genre.memeList.push(memes.filter(x => x.title == 'Szechuan Sauce')[0]._id)
                        genre.memeList.push(memes.filter(x => x.title == 'Jerry Smith')[0]._id)
                        genre.memeList.push(memes.filter(x => x.title == '"Get Schwifty"')[0]._id)
                        genre.memeList.push(memes.filter(x => x.title == 'Wubalubadubdub')[0]._id)
                        genre.save()
                    })
                    Genre.findOne({ genreName: 'NotRickAndMorty' }).then((genre) => {
                        genre.memeList.push(memes.filter(x => x.title == "Hi I'm Mr meeseeks look at me")[0]._id)
                        genre.save()
                    })
                    Genre.create({ genreName: 'ALL' }).then((genreAll) => {
                        for (let meme of memes) {
                            genreAll.memeList.push(meme._id)
                        }
                        genreAll.save()
                    })
                    renderAllMemes(memes)
                })
            })
        } else {
            Meme.find().then((memes) => {
                renderAllMemes(memes)
            })
        }

        function renderAllMemes(memes) {
            let content = ''
            for (let meme of memes.sort(x => x.dateOfCreation).reverse()) {
                if (meme.privacy == 'on') {
                    content += `<div class="meme">
                    <a href="/getDetails?id=${meme._id}">
                    <img class="memePoster" src="${meme.image}"/>          
                    </div>`
                }
            }
            res.render('viewAll', { content })
        }
    })
}

module.exports.searchMemeGet = (req, res) => {
    Genre.find().then((genres) => {

        let content = ''
        for (let genre of genres) {
            content += `<option value="${genre.genreName}">${genre.genreName}</option>`
        }
        res.render('searchMeme', { content })
    })
}

module.exports.searchMemePost = (req, res) => {
    Genre.findOne({ genreName: req.body.genreSelect }).then((genre) => {

        let count = 1
        for (let memeId of genre.memeList) {
            Meme.findOne({ _id: memeId }).then((meme) => {
                if (meme.title.toLowerCase().includes(req.body.memeTitle.toLowerCase())) {
                    let content = ''
                    if (meme.privacy == 'on') {
                        content += `<div class="meme">
                        <a href="/getDetails?id=${meme._id}">
                        <img class="memePoster" src="${meme.image}"/>          
                        </div>`
                    }
                    res.render('viewAll', { content })
                    return
                } 
                else if (count == genre.memeList.length) {
                    res.render('viewAll', {content: '<h1>404 Not Found</h1>'})
                    return
                }
                count++
            })
        }
    })
}

module.exports.addGenreGet = (req, res) => {
    res.render('addGenre')
}

module.exports.addGenrePost = (req, res) => {
    let name = req.body.genreTitle
    Genre.create({ genreName: name }).then(() => {
        res.redirect('/')
    })
}

module.exports.statusGet = (req, res) => {
    Genre.find().then((genres) => {
        Meme.find().then((memes) => {
            let content = `There are currently ${genres.length} genres and ${memes.length} memes.`
            res.render('status', { content })
        })
    })

}

module.exports.getDetailsGet = (req, res) => {
    let id = req.originalUrl.split('=').pop()

    Meme.findById(id).then((meme) => {

        let content = `<div class="content">
            <img src="${meme.image}" alt=""/>
            <h3>Title: ${meme.title}</h3>
            <p> ${meme.description}</p>
            <button><a href="${meme.image}" download>Download Meme</a></button>
            </div>`

        res.render('details', { content })
    })
}