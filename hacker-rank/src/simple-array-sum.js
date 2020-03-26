// Challenge URL:
// https://www.hackerrank.com/challenges/simple-array-sum/problem

/*
 * Complete the simpleArraySum function below.
 */
function simpleArraySum(ar) {
    var sum=0;
    for (var i=0;i<ar.length;i++){
        sum+=ar[i];
    }
    return sum;
}