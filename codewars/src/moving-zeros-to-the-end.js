var moveZeros = function(arr) {
  // get current length of arr
  l = arr.length;
  // set increment starting at index 0
  n = 0;
  // while increment is less than (current) array length
  while (n < l) {
    // if current element in array is 0
    if (arr[n] === 0) {
      // add 0 to end of array
      arr.push(0);
      // remove current element from array
      arr.splice(n, 1);
      // reduce length by the 0 at the end, go back one iteration (arr[3] is now arr[2] if arr[2] was removed as a 0)
      l--;
      n--;
    }
    // go to next iteration
    n++;
  }
  return arr;
};