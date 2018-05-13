class TitleBar {
    constructor(title) {
        this.title = title
        this.links = []
    }

    addLink(href, name) {
        this.links.push({ href, name })
    }

    appendTo(selector) {
        $(selector).find('.header').remove()
        let nav = $('<nav>').addClass('menu')
        for (let link of this.links) {
            nav.append($('<a>').addClass('menu-link').attr('href', `${link.href}`).text(link.name))
        }

        $(selector).prepend($('<header>').addClass('header')
            .append($('<div>').addClass('header-row')
                .append($('<a>').addClass('button').html('&#9776;').on('click', function () {
                    if (($('.drawer')).css('display') == 'none') {
                        ($('.drawer')).css('display', 'block');
                    } else {
                        ($('.drawer')).css('display', 'none');
                    }
                }))
                .append($('<span>').addClass('title').text(this.title))
            )//end of first div
            .append($('<div>').addClass('drawer').hide()
                .append($(nav)
                )//end of nav
            )//end of the scond div
        )//end of header
    }
}

let header = new TitleBar('Title Bar Problem');
header.addLink('/', 'Home');
header.addLink('about', 'About');

header.addLink('results', 'Results');
header.addLink('faq', 'FAQ');
header.appendTo('#container');