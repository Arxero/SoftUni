(function solution() {
    String.prototype.ensureStart = function (input) {
        if (!this.toString().startsWith(input)) {
            return input + this.toString()
        } else {
            return this.toString()
        }
    }

    String.prototype.ensureEnd = function (input) {
        if (!this.toString().endsWith(input)) {
            return this.toString() + input
        } else {
            return this.toString()
        }
    }

    String.prototype.isEmpty = function () {
        if (this.length == 0) {
            return true
        } else {
            return false
        }
    }

    String.prototype.truncate = function (n) {
        if (n < 4) {
            return '.'.repeat(n)
        }
        if (this.toString().length <= n) {
            return this.toString()
        } else {
            let lastIndex = this.toString().substr(0, n - 2).lastIndexOf(' ')
            if (lastIndex != -1) {
                return this.toString().substr(0, lastIndex) + '...'
            } else {
                return this.toString().substr(0, n - 3) + '...'
            }
        }
    }

    String.format = function (input, ...params) {
        for (let i = 0; i < params.length; i++) {
            let index = input.indexOf('{' + i + '}')
            while (index != -1) {
                input = input.replace('{' + i + '}', params[i])
                index = input.indexOf('{' + i + '}')
            }
        }
        return input
    }
})()