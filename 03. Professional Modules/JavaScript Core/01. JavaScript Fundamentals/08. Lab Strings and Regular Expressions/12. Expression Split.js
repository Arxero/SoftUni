function split(input) {
    //let pattern = /(\s*\(*\)*,*;*\.*)+/gm;
    let pattern = /[\s.();,]+/;
    //let result = input.match(pattern);
    console.log(input.split(pattern).join('\n'));
}
//split('let sum = 4 * 4,b = "wow";');
//split('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}');