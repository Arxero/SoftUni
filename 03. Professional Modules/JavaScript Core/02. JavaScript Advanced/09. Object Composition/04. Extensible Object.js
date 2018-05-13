function solution() {
    let result = {
        extend: function (template) {
            for (let key of Object.keys(template)) {
                if (typeof(template[key]) == 'function') {
                    Object.getPrototypeOf(result)[key] = template[key]
                }else {
                    result[key] = template[key]
                }
            }
        }
    }
    return result
}