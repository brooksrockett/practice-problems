const fs = require("fs");

const numerals = {
  M: 1000,
  CM: 900,
  D: 500,
  CD: 400,
  C: 100,
  XC: 90,
  L: 50,
  XL: 40,
  X: 10,
  IX: 9,
  V: 5,
  IV: 4,
  I: 1,
};

const file = fs.readFileSync(path.resolve(__dirname, "roman.txt"), "utf8");

var romanToInt = function (s) {
  let sum = 0;
  while (s.length > 0) {
    for (let key in numerals) {
      numeral = numerals[key];
      while (s.startsWith(key)) {
        sum += numeral;
        s = s.substr(s.indexOf(key) + key.length);
      }
    }
  }
  return sum;
};

var intToRoman = function (n) {
  string = "";
  while (n > 0) {
    for (let key in numerals) {
      numeral = numerals[key];
      while (n >= numeral) {
        string += key;
        n -= numeral;
      }
    }
  }
  return string;
};

function compareCharacterCount(input) {
  let lines = input.split("\n");
  let chars = 0;
  let origChars = 0;
  for (let line of lines) {
    origChars += line.length;
    chars += intToRoman(romanToInt(line)).length;
  }
  return origChars - chars;
}

console.log(compareCharacterCount(file));
