function solution() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new Error("Abstract class cannot be instantiated directly")
            }
            this.weight = weight
            this.melonSort = melonSort
        }
        get elementIndex() {
            return this.weight * this.melonSort.length
        }
        toString() {
            return `\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`
        }
    }

    class Watermelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Water'
        }

        toString() {
            return `Element: ${this.element}` + super.toString()
        }
    }

    class Firemelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Fire'
        }
        toString() {
            return `Element: ${this.element}` + super.toString()
        }
    }

    class Earthmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Earth'
        }
        toString() {
            return `Element: ${this.element}` + super.toString()
        }
    }

    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Air'
        }
        toString() {
            return `Element: ${this.element}` + super.toString()
        }
    }

    class Melolemonmelon extends Watermelon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
        }
        morph() {
            switch (this.element) {
                case 'Water':
                    this.element = 'Fire'
                    break;
                case 'Fire':
                    this.element = 'Earth'
                    break;
                case 'Earth':
                    this.element = 'Air'
                    break;
                case 'Air':
                    this.element = 'Water'
                    break;
            }
        }
    }

    return { Melon, Watermelon, Firemelon, Earthmelon, Airmelon, Melolemonmelon }
}