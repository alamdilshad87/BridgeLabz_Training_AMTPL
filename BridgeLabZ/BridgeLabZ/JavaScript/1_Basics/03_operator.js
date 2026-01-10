// Arithmetic Operators
const a = 20;
const b = 6;

console.log("Addition:", a + b);
console.log("Subtraction:", a - b);
console.log("Multiplication:", a * b);
console.log("Division:", a / b);
console.log("Modulus:", a % b);

// Assignment Operators
let count = 10;

count += 5;
count -= 3;
count *= 2;

console.log("Final Count:", count);

// Comparison Operators
console.log("10 > 5:", 10 > 5);
console.log("10 < 5:", 10 < 5);
console.log("10 >= 10:", 10 >= 10);
console.log("10 <= 9:", 10 <= 9);

// Equality Operators (IMPORTANT)
console.log("5 == '5':", 5 == "5");
console.log("5 === '5':", 5 === "5");
console.log("5 !== '5':", 5 !== "5");

// Logical Operators
const isLoggedIn = true;
const isAdmin = false;

console.log("AND condition:", isLoggedIn && isAdmin);
console.log("OR condition:", isLoggedIn || isAdmin);
console.log("NOT condition:", !isLoggedIn);

// Real-World Example: Login Validation
const email = "user@gmail.com";
const password = "123456";

const isValidLogin =
  email === "user@gmail.com" &&
  password === "123456";

console.log("Login Valid:", isValidLogin);

// Real-World Example: Salary Eligibility
const salary = 45000;
const hasExperience = true;

const isEligible =
  salary >= 30000 && hasExperience === true;

console.log("Eligible for Job:", isEligible);