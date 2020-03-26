// Challenge URL:
// https://www.hackerrank.com/challenges/dynamic-array/problem

/*
 * Complete the 'dynamicArray' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. 2D_INTEGER_ARRAY queries
 */

function dynamicArray(n, queries) {
    let lastAnswer = 0;
    let res = new Array(); // problem says to print, but tests want an array
    let seqList = new Array(); // seqList will be an array of (seq) arrays
    for (let number=0;number<n;number++) {seqList[number] = new Array();} // create n seq arrays for seqList
    for (let q of queries) {
        let x = q[1];
        let y = q[2];
        let seq = seqList[((x^lastAnswer)%n)];
        if (q[0] === 1) { // if query starts with 1
            seq.push(y);
        }
        else { // if query starts with 2 (!=1)
            lastAnswer = seq[y%seq.length];
            res.push(lastAnswer); // add lastAnswer to result array
        }
    }
    return res;
}