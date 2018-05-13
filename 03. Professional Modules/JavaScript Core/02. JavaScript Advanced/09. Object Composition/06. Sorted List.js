function solution() {
    let result = (() => {
        let arr = []
        let sorting = (a, b) => a - b

        let add = function (input) {
            arr.push(input)
            arr.sort(sorting)
            this.size++
            return arr
        }
        let remove = function (index) {
            if (index >= 0 && index < arr.length) {
                arr.splice(index, 1)
                this.size--
                arr.sort(sorting)
                return arr
            }
        }
        let get = function (index) {
            if (index >= 0 && index < arr.length) {
                return arr[index]
            }
        }
        let size = 0
        return { add, remove, get, size }
    })()
    return result
}