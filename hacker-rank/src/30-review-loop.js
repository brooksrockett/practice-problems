function processData(input) {
  //Enter your code here
  sinput = input.split(/\n/);
  for (let n of Array(Number(sinput[0])+1).keys()) {
    if (n === 0) {
    } else {
      
      var str1 = '';
      var str2 = '';
      //sinput[n] = 'Hacker'
      for (let l in sinput[n]) {
        if (l%2==0) {
          str1+=sinput[n][l]
        }
        else {
          str2+=sinput[n][l]
        }
      }
      console.log(str1+' '+str2)
    }
  }
}