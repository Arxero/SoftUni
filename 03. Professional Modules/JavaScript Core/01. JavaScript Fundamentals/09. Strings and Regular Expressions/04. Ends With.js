function endsWith(input, text) {
    if (input.indexOf(text) != input.length - text.length) {
        console.log('false');
    }
    else {
        console.log('true');
    }
}
// endsWith('This sentence ends with fun?', 'fun?');
// endsWith('The new iPhone has no headphones jack.', 'o headphones jack.');
// endsWith('This is Houston, we have…', 'We have…');