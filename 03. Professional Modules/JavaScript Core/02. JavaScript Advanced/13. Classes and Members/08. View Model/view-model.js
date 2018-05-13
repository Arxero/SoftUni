class Textbox {
    constructor(selector, regex) {
        this.selector = selector
        this._invalidSymbols = regex
        this._elements = $(this.selector)
        $(this.selector).on('input', function () {
            $('*[type=text]').val(this.value)
        })
    }

    get elements() {
        return this._elements
    }

    set value(input) {
        this.elements.val(input)
    }

    get value() {
        return this.elements.val()
    }

    isValid() {
        if (this._invalidSymbols.test(this.value)) {
            return false
        } else {
            return true
        }
    }
}