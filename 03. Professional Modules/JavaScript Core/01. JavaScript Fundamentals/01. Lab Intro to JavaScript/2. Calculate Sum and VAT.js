function sumVat(arr){
    let sum = 0;
    for (let i = 0; i < arr.length; i++){
        sum += arr[i];
    }
    
    console.log(`sum = ${sum}`);
    let vat = sum * 0.2;
    console.log(`VAT = ${vat}`);
    console.log(`total = ${sum + vat}`);
}