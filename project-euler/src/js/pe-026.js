function longDivision(r, num, arr) {
  let rem = r % num;
  if (arr.includes(rem)) {
    return arr.length;
  }
  arr.push(rem);
  //console.log(`pushing ${rem}`)
  return longDivision(rem * 10, num, arr);
}

function main(len) {
  let max = 0;
  for (let i of Array(len).keys()) {
    if (longDivision(1, i, []) > max) {
      max = i;
    }
  }
  return max;
}

console.log(main(1000));