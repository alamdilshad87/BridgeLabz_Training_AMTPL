function add(a, b) {
  return a + b;
}

console.log("Add Result:", add(10, 5));

function calculateSalary(days, perDay) {
  return days * perDay;
}

const salary = calculateSalary(22, 1000);
console.log("Calculated Salary:", salary);

function checkEligibility(age) {
  if (age >= 18) {
    return "Eligible";
  }
  return "Not Eligible";
}

console.log("Voting Check:", checkEligibility(20));
console.log("Voting Check:", checkEligibility(15));

const multiply = function (x, y) {
  return x * y;
};

console.log("Multiply Result:", multiply(4, 5));

const divide = (x, y) => x / y;

console.log("Divide Result:", divide(20, 4));

function testReturn(value) {
  if (value > 10) {
    return value * 2;
  }
  return value + 2;
}

console.log("Test Result:", testReturn(8));
console.log("Test Result:", testReturn(12));