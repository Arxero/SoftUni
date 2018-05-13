() => (() => {
    let ingredients = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }

    return function (input) {
        let splitter = input.split(' ')
        let command = splitter.shift()
        switch (command) {
            case 'restock': return restock(splitter); break;
            case 'prepare': return prepare(splitter); break;
            case 'report': return report();
        }
    }

    function restock([microelement, quantity]) {
        ingredients[microelement] += Number(quantity)
        return 'Success'
    }

    function prepare([recipe, quantity]) {
        quantity = Number(quantity)
        let message = ''
        switch (recipe) {
            case 'apple':
                if (ingredients['flavour'] < quantity * 2) {
                    message = "Error: not enough flavour in stock"
                }
                if (ingredients['carbohydrate'] < quantity) {
                    message = "Error: not enough carbohydrate in stock"
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 2
                    ingredients['carbohydrate'] -= quantity
                    return 'Success'
                }
                return message
                break;

            case 'coke':
                if (ingredients['flavour'] < quantity * 20) {
                    message = "Error: not enough flavour in stock"
                }
                if (ingredients['carbohydrate'] < quantity * 10) {
                    message = "Error: not enough carbohydrate in stock"
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 20
                    ingredients['carbohydrate'] -= quantity * 10
                    return 'Success'
                }
                return message
                break;

            case 'burger':
                if (ingredients['flavour'] < quantity * 3) {
                    message = "Error: not enough flavour in stock"
                }
                if (ingredients['fat'] < quantity * 7) {
                    message = "Error: not enough fat in stock"
                }
                if (ingredients['carbohydrate'] < quantity * 5) {
                    message = "Error: not enough carbohydrate in stock"
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 3
                    ingredients['fat'] -= quantity * 7
                    ingredients['carbohydrate'] -= quantity * 5
                    return 'Success'
                }
                return message
                break;

            case 'omelet':
                if (ingredients['flavour'] < quantity * 1) {
                    message = "Error: not enough flavour in stock"
                }
                if (ingredients['fat'] < quantity * 1) {
                    message = "Error: not enough fat in stock"
                }
                if (ingredients['protein'] < quantity * 5) {
                    message = "Error: not enough protein in stock"
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 1
                    ingredients['fat'] -= quantity * 1
                    ingredients['protein'] -= quantity * 5
                    return 'Success'
                }
                break;

            case 'cheverme':
                if (ingredients['flavour'] < quantity * 10) {
                    message = "Error: not enough flavour in stock"
                }
                if (ingredients['fat'] < quantity * 10) {
                    message = "Error: not enough fat in stock"
                }
                if (ingredients['carbohydrate'] < quantity * 10) {
                    message = "Error: not enough carbohydrate in stock"
                }
                if (ingredients['protein'] < quantity * 10) {
                    message = "Error: not enough protein in stock"
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 10
                    ingredients['fat'] -= quantity * 10
                    ingredients['carbohydrate'] -= quantity * 10
                    ingredients['protein'] -= quantity * 10
                    return 'Success'
                }
                return message
                break;
        }
    }

    function report() {
        return `protein=${ingredients['protein']} carbohydrate=${ingredients['carbohydrate']} fat=${ingredients['fat']} flavour=${ingredients['flavour']}`
    }

})()
//manager("restock flavour 50")