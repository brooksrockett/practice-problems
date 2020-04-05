function validParentheses(parens) {
    let i = 0;
    let len = parens.length;
    // iterate for each char in original string
    while (i <= len) {
      // regex replace all matching pairs '()'
      parens = parens.replace(/\(\)/i, "");
      // if string has become empty
      if (parens == "") {
        return true;
      }
      // otherwise go to next iteration
      i++;
    }
    // if iteration complete and still not empty string
    return false;
  }