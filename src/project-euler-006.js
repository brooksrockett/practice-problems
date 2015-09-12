var sum = 0;
var square = 0;
for (i = 1; i <=100; i++)
{
    sum = sum + (i * i);
    square = square + i;
}
square = square * square;
var diff = square - sum;
console.log("The square is " + square);
console.log("The sum is " + sum);
console.log("The difference between the square and sum is " + diff);