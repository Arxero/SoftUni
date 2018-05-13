class Sort {
    constructor() {
        this.arr = []
        this.size = 0
    }
    add(elemenent) {
        this.size++
        this.arr.push(elemenent)
        this.arr.sort((a,b) => a-b)
        return this.arr
        
    }
    remove(index) {
        if (index >= 0 && index < this.arr.length) {
            this.size--
            this.arr.splice(index, 1)
            this.arr.sort((a,b) => a-b)
            return this.arr
        }
    }
    get(index) {
        if (index >= 0 && index < this.arr.length) {
            return this.arr[index]
        }
    }
}
// let a = new Sort([10, 20, 30])
// console.log(a.get(2));
