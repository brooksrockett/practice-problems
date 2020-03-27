function alphabetPosition(text){
  const alphabet = [...'abcdefghijklmnopqrstuvwxyz']; // init array of characters
  const sentence = text.toLowerCase().split(''); // text to array, lowercase
  let str = '';
  for (const letter of sentence) {
    if (alphabet.indexOf(letter) >= 0) { // if the character is a-z,
      str+=alphabet.indexOf(letter)+1+' '; // add the index, + 1 for zeroth, + space before next letter
    }
  }
return str.trim(); // trim trailing whitespace
}