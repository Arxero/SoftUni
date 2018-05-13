function parser(input) {
    let svgPattern = /.*<svg>(.*)<\/svg>.*/;
    let catPattern = /(?:<cat>(.*?)<\/cat>){2}/;
    let textPattern = /<text>(.*?)<\/text>/g;
    let food = '';
    let sum = 0;
    let countSum = 0;

    let svgMatch = svgPattern.exec(input);

    if (svgMatch) {
        let catMatch = catPattern.exec(svgMatch[1]);
        if (catMatch) {
            let pattern = /<cat>(.*?)<\/cat>/g;
            let catMatchGroup1 = pattern.exec(catMatch[0]);
            let label1 = catMatchGroup1[0];
            let label2 = '';
            while (catMatchGroup1) {
                catMatchGroup1 = pattern.exec(catMatch[0]);
                label2 = catMatchGroup1[0];
                break;

            }
            if (label1 != null) {
                let patternRatingCount = /<g><val>([0-9]+)<\/val>([0-9]+)<\/g>/g;
                let matchRatingCount = patternRatingCount.exec(label2);
                let value = 0;
                let count = 0;

                while (matchRatingCount) {
                    value = Number(matchRatingCount[1]);
                    count = Number(matchRatingCount[2]);
                    sum += value * count;
                    countSum += count;
                    matchRatingCount = patternRatingCount.exec(label2);
                }
            }

            let bracketMatch = /\[(.*)\]/.exec(label1);
            if (bracketMatch) {
                food = bracketMatch[1];
            }
            if (bracketMatch == null) {
                console.log('Invalid format');
                return;
            }
            if (label1 == null || label2 == null) {
                console.log('Invalid format');
                return;
            }
        } else {
            console.log('Invalid format');
            return;
        }

    } else {
        console.log('No survey found');
        return;
    }
    let result  = sum / countSum;
    console.log(`${food}: ${Math.round(result * 100) / 100}`);
}
//parser(`<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>`);
//parser(`<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat><cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>`);
//parser(`<p>How do you suggest we improve our service?</p><p>More tacos.</p><p>It's great, don't mess with it!</p><p>I'd like to have the option for delivery</p>`);
//parser(`<svg><cat><text>Which is your favourite meal from our selection?</text></cat><cat><g><val>Fish</val>15</g><g><val>Prawns</val>31</g><g><val>Crab Langoon</val>12</g><g><val>Calamari</val>17</g></cat></svg>`);
parser(`
<cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat>
<g><val>1</val>5</g>
<g><val>5</val>13</g>
<g><val>10</val>22</g>
</cat>
</svg>
`);
parser(`<svg><cat><text>How do you rate the special menu? [Food - Special]</text>
</cat><cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>`)