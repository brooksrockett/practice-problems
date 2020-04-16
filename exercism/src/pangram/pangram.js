//
// This is only a SKELETON file for the 'Pangram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

// ASCII character codes for a, z
const a = 97;
const z = 122;

export const isPangram = (sentence) => {
  // convert sentence to lower for easier matching
  sentence = sentence.toLowerCase();
  // for each chararacter starting with 97 (a) to 122 (z)
  for (let i = a; i <= z; i++) {
    // if any char from a-z is not present in sentence
    if (!sentence.includes(String.fromCharCode(i))) {
      return false;
    }
  }
  // otherwise
  return true;
};
