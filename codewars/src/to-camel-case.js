function toCamelCase(str) {
  arr = str.split(/-|_/);
  var ns = "";
  if (!str) {
    return "";
  }
  for (var word of arr) {
    ns += word.substr(0, 1).toUpperCase();
    ns += word.substr(1);
  }
  if (str[0][0].match(/[a-z]/)) {
      var lower = ns.substr(0,1).toLowerCase();
      lower += ns.substr(1);
      return lower;
  }
  return ns;
}

console.log(toCamelCase(""));
console.log(toCamelCase("the_stealth_warrior"));
console.log(toCamelCase("The-Stealth-Warrior"));