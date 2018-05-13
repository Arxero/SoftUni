let result = (function () {
    class Textbox {
        constructor(selector, regex) {
            this.selector = selector
            this._invalidSymbols = regex
            this._elements = $(this.selector)
            let that = this
            $(this.selector).on('input', function () {
                that.value = this.value;
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

    class Form {
        constructor(...textboxes) {
            if (textboxes.some(x => x instanceof Textbox)) {
                this._element = $('<div>').addClass('form')
                this._textboxes = textboxes
                for (let textbox of textboxes) {
                    this._element.append($(textbox.selector))
                }
            } else {
                throw new Error('Some of the constructor arguments are not a Textbox')
            }
        }

        submit() {
            let allValid = true
            for (let textbox of this._textboxes) {
                if (textbox.isValid()) {
                    $(textbox.selector).css('border', '2px solid green');
                } else {
                    $(textbox.selector).css('border', '2px solid red');
                    allValid = false
                }
            }
            return allValid
        }

        attach(selector) {
            $(selector).append($(this._element))
        }
    }
    return {
        Textbox: Textbox,
        Form: Form
    }

}())

// let Textbox = result.Textbox;
// let Form = result.Form;
// let username = new Textbox("#username", /[^a-zA-Z0-9]/);
// let password = new Textbox("#password", /[^a-zA-Z]/);
// username.value = "username";
// password.value = "password2";
// let form = new Form(username, password);
// form.attach("#root");