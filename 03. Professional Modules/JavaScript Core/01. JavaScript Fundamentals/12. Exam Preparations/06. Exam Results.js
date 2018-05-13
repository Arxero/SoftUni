function exam(input) {
    let whichCourse = input.pop().trim();
    let counter = 0;
    let totalCoursePoints = 0;

        for (let row of input) {
            let splitter = row.split(' ').filter(s => s != '');
            let name = splitter[0];
            let course = splitter[1];
            let examPoints = +splitter[2];
            let bonusPoints = +splitter[3];

            let coursePoints = examPoints - (examPoints * 0.8) + bonusPoints;
            let grade = ((coursePoints / 80) * 4) + 2;
            if (grade > 6) {
                grade = 6;
            }

            if (whichCourse == course) {
                counter++;
                totalCoursePoints += examPoints;
            }

            if (examPoints >= 100) {
                console.log(`${name}: Exam - "${course}"; Points - ${Math.round(coursePoints * 100) / 100}; Grade - ${grade.toFixed(2)}`);
            }
            else{
                console.log(`${name} failed at "${course}"`);
            }
        }
        let averagePoints = totalCoursePoints / counter;
        console.log(`"${whichCourse}" average points -> ${Math.round(averagePoints * 100) / 100}`);
}
// exam([
//     'Pesho C#-Advanced 100 3',
//     'Gosho Java-Basics 157 3',
//     'Tosho HTML&CSS 317 12',
//     'Minka C#-Advanced 57 15',
//     'Stanka C#-Advanced 157 15',
//     'Kircho C#-Advanced 300 0',
//     'Niki C#-Advanced 400 10',
//     'C#-Advanced'
// ]);

// exam([
// '    EDUU    JS-Basics                317          15   ',    
// '    RoYaL        HTML5        121         10  ',      
// 'ApovBerger      OOP   0    10     ',
// 'Stamat OOP   190 10',
// 'MINKA OOP   230 10',
// '   OOP'
// ]);