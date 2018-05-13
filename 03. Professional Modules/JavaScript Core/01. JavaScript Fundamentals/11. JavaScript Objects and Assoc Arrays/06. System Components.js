function components(input) {
    let results = new Map();

    for (let row of input) {
        let splitter = row.split(' | ');
        let system = splitter[0];
        let component = splitter[1];
        let subComponent = splitter[2];

        if (!results.has(system)) {
            results.set(system, new Map());
        }
        if (!results.get(system).has(component)) {
            results.get(system).set(component, []);
        }
        results.get(system).get(component).push(subComponent);
    }
    let sortedSystem = Array.from(results.keys()).sort((a, b) => sortSystems(a, b));
    
    for (let result of sortedSystem) {
        console.log(result);
        let sortedComponents = Array.from(results.get(result).keys()).sort((a, b) => SortComponents(result, a, b));

        for (let component of sortedComponents) {
            console.log(`|||${component}`);
            results.get(result).get(component).forEach(element => console.log(`||||||${element}`));
        }
    }


    //sorting function for system
    function sortSystems(a, b) {
        if (results.get(a).size != results.get(b).size) {
            return results.get(b).size - results.get(a).size;
        }
        else {
            return a.toLowerCase().localeCompare(b.toLowerCase());
        }
    }

    //sort for components
    function SortComponents(result, a, b) {
        return results.get(result).get(b).length - results.get(result).get(a).length
    }

}
// components([
//     'SULS | Main Site | Login Page',
//     'SULS | Main Site | Register Page',
//     'SULS | Judge Site | Login Page',
//     'SULS | Judge Site | Submittion Page',
//     'Lambda | CoreA | A23',
//     'SULS | Digital Site | Login Page',
//     'Lambda | CoreB | B24',
//     'Lambda | CoreA | A24',
//     'Lambda | CoreA | A25',
//     'Lambda | CoreC | C4',
//     'Indice | Session | Default Storage',
//     'Indice | Session | Default Security'
// ]);