function sumSquares(num) {
    sum = 0;
    for (i=1;i<=num;i++) {
        sum+=i**2;
    }
    return sum;
}

function squareSums(num) {
    sum = 0;
    for (i=1;i<=num;i++) {
        sum+=i;
    }
    return sum**2;
}

// console.log(sumSquares(10));
// console.log(squareSums(10));
// console.log(squareSums(10)-sumSquares(10));
// console.log(sumSquares(100));
// console.log(squareSums(100));
console.log(squareSums(100)-sumSquares(100));