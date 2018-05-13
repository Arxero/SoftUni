function solution(input) {
    let result = {}
    let controlers = {};
    let models = {};
    let views = {};

    for (let row of input) {
        let splitter = row.split('&')
        let elementOwnerShip

        if (row.includes('$app')) {
            let app = row.split('$app=').filter(x => x != '')
            app = app[0].slice(1, app[0].length - 1)
            result[app] = {}
        }
        if (row.includes('$controller')) {
            let controller = splitter[0].split('$controller=').filter(x => x != '')
            controller = controller[0].slice(1, controller[0].length - 1)
            elementOwnerShip = splitter[1].split('app=').filter(x => x != '')
            elementOwnerShip = elementOwnerShip[0].slice(1, elementOwnerShip[0].length - 1)

            if (!controlers[elementOwnerShip]) {
                controlers[elementOwnerShip] = []
            }
            controlers[elementOwnerShip].push(controller)
        }
        if (row.includes('$model')) {
            let model = splitter[0].split('$model=').filter(x => x != '')
            model = model[0].slice(1, model[0].length - 1)
            elementOwnerShip = splitter[1].split('app=').filter(x => x != '')
            elementOwnerShip = elementOwnerShip[0].slice(1, elementOwnerShip[0].length - 1)

            if (!models[elementOwnerShip]) {
                models[elementOwnerShip] = []
            }
            models[elementOwnerShip].push(model)
        }
        if (row.includes('$view')) {
            let view = splitter[0].split('$view=').filter(x => x != '')
            view = view[0].slice(1, view[0].length - 1)
            elementOwnerShip = splitter[1].split('app=').filter(x => x != '')
            elementOwnerShip = elementOwnerShip[0].slice(1, elementOwnerShip[0].length - 1)

            if (!views[elementOwnerShip]) {
                views[elementOwnerShip] = []
            }
            views[elementOwnerShip].push(view)
        }
    }

    for (let app of Object.keys(result)) {
        let ctrls = controlers[app] != undefined ? controlers[app].sort((a, b) => a.localeCompare(b)) : []
        let mdls = models[app] != undefined ? models[app].sort((a, b) => a.localeCompare(b)) : []
        let vs = views[app] != undefined ? views[app].sort((a, b) => a.localeCompare(b)) : []

        result[app] = {
            'controllers': ctrls,
            'models': mdls,
            'views': vs
        }
    }

    let sortedOutput = {}
    let sorted = Object.keys(result).sort((a, b) => {
        if (result[a]['controllers'].length == result[b]['controllers'].length) {
            return result[a].models.length - result[b].models.length
        }
        return result[b].controllers.length - result[a].controllers.length
    })
    sorted.forEach((value) => {
        sortedOutput[value] = result[value]
    })
    return JSON.stringify(sortedOutput)
}

// console.log(solution([
//     `$app='MyApp'`,
//     `$controller='My Controller'&app='MyApp'`,
//     `$model='My Model'&app='MyApp'`,
//     `$view='My View'&app='MyApp'`
// ]));

console.log(solution([
    `$controller='PHPController'&app='Language Parser'`,
    `$controller='JavaController'&app='Language Parser'`,
    `$controller='C#Controller'&app='Language Parser'`,
    `$controller='C++Controller'&app='Language Parser'`,
    `$app='Garbage Collector'`,
    `$controller='GarbageController'&app='Garbage Collector'`,
    `$controller='SpamController'&app='Garbage Collector'`,
    `$app='Language Parser'`
]));