// Complete the isBalanced function below.
function isBalanced(s) {
  let i = 0;
  let len = s.length;
  // iterate for each char in original string
  while (i <= len) {
    // regex replace all matching pairs '()', '{}', '[]'
    s = s.replace(/\(\)|{}|\[\]/i, "");
    // if string has become empty
    if (s == "") {
      return "YES";
    }
    // otherwise go to next iteration
    i++;
  }
  // if iteration complete and still not empty string
  return "NO";
}
