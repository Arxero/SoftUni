class Rat {
    constructor(name){
        this.name = name
        this.unitedRats = []
    }
    unite(otherRat){
        if (otherRat instanceof Rat) {
            this.unitedRats.push(`##${otherRat}`)
        }
    }
    getRats(){
        return this.unitedRats
    }
    toString(){
        return this.name + '\n' + this.unitedRats.join('')
    }
}
// let test = new Rat ('Pesho')
// test.unite(new Rat("Gosho"));
// test.unite(new Rat("Sasho"));
// console.log(test.toString());
