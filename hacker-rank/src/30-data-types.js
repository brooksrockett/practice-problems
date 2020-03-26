// Challenge URL:
// https://www.hackerrank.com/challenges/30-data-types/problem

function main() {
    var i = 4
    var d = 4.0
    var s = "HackerRank "
    // Declare second integer, double, and String variables.

    // Read and save an integer, double, and String to your variables.

    // Print the sum of both integer variables on a new line.

    // Print the sum of the double variables on a new line.

    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    var i2 = Number(readLine()); // i2 & d2 must be converted to numbers from strings
    var d2 = Number(readLine());
    var s2 = readLine(); // data is submitted as separate inputs, not one separated by \n
    console.log(i+i2);
    console.log((d+d2).toFixed(1)); // translate the sum of d+d2 to a fixed-point decimal
    console.log(s+s2);
}