function minimumAge(minAge, firstName, age1, secondName, age2){
let obj1 = {name: firstName, age: age1};
let obj2 = {name: secondName, age: age2};
if (obj1.age >= minAge) {
    console.log(obj1);
}
if (obj2.age >= minAge) {
    console.log(obj2);
}
}