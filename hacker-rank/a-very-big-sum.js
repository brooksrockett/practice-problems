// Challenge URL:
// https://www.hackerrank.com/challenges/a-very-big-sum/problem

// Complete the aVeryBigSum function below.
function aVeryBigSum(ar) {
    var sum=0;
    for (let i of ar) {
        sum+=i;
    }
    return sum;
}