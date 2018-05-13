function result() {
    let summary = {}
    for (let i = 0; i < arguments.length; i++) {
        console.log(`${typeof(arguments[i])}: ${arguments[i]}`)

        if (!summary[typeof(arguments[i])]) {
            summary[typeof(arguments[i])] = 1
        }else {
            summary[typeof(arguments[i])]++
        }
    }
    Object.keys(summary).sort((a, b) => summary[b] > summary[a])
    .forEach(k => console.log(`${k} = ${summary[k]}`)) 
}
//result('cat', 42, function () { console.log('Hello world!'); });