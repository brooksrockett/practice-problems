var squares = [];
for (const i in [...Array(100000).keys()]) { // create array of first 100000 squares
    squares.push(i*i);
}

var isSquare = function(n) {
  if (squares.includes(n)) { // if n is one of the first 100000 squares
    return true;
  }
return false;
}