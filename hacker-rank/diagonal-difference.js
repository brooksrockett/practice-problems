// Challenge URL:
// https://www.hackerrank.com/challenges/diagonal-difference/problem


/*
 * Complete the 'diagonalDifference' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */
function diagonalDifference(arr) {
    let num1=0;
    let num2=0;
    for (let i in arr) {
        num1+=arr[i][i];
        num2+=arr[arr.length-i-1][i];
    }
    return Math.abs(num2-num1);
}