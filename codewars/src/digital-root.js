function digital_root(n) {
  const arr = Array.from(String(n), Number); // n to int array
  let sum = 0;
  for (const i in arr) {
    sum += arr[i];
  }
  if (sum / 10 >= 1) { // recurse if sum >= 10
    return digital_root(sum);
  }
  return sum;
}