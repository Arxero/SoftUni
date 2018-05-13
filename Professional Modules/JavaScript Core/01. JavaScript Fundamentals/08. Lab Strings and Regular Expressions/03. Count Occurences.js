function getOcurrs(word, text) {
    let counter = 0;
    let index = text.indexOf(word);

    while (index != -1) {
        index++;
        counter++;
        index = text.indexOf(word, index);
    }
    console.log(counter);
}
//getOcurrs('the', 'The quick brown fox jujumps over the lay dog.');
//getOcurrs('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.');