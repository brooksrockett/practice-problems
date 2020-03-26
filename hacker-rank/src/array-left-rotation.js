// Challenge URL:
// https://www.hackerrank.com/challenges/array-left-rotation/problem

function main() {
    const nd = readLine().split(' ');
    const n = parseInt(nd[0], 10);
    const d = parseInt(nd[1], 10);
    const a = readLine().split(' ').map(aTemp => parseInt(aTemp, 10));

    for (let i=0;i<d;i++) {
        a[a.length-1] = a.shift();
    }

    console.log(a.join(' '));
}