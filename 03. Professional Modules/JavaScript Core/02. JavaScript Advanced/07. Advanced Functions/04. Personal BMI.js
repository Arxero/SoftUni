function bmi(name, age, weight, height) {
    let info = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight, 
            height: height
        },
        BMI: Math.round(weight /(height * height / 10000))
    }
    if (info.BMI < 18.5 ) {
        info.status = 'underweight'
    }else if (info.BMI >= 18.5 && info.BMI < 25) {
        info.status = 'normal'
    }else if (info.BMI >= 25 && info.BMI < 30) {
        info.status = 'overweight'
    }else {
        info.status = 'obese'
        info.recommendation = 'admission required'
    }
    return info
}
//bmi('Peter', 29, 75, 182);
//bmi('Honey Boo Boo', 9, 57, 137);