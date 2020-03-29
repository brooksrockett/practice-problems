// Challenge URL:
// https://www.hackerrank.com/challenges/30-data-types/problem

// Complete the solve function below.
function solve(meal_cost, tip_percent, tax_percent) {
  let tip = meal_cost * (tip_percent / 100);
  let tax = meal_cost * (tax_percent / 100);
  let totalCost = meal_cost + tip + tax;
  console.log(Math.round(totalCost));
}
