const age = 20;

if (age >= 18) {
  console.log("Voting Status:", "Eligible");
}

const marks = 45;

if (marks >= 40) {
  console.log("Exam Result:", "Pass");
} else {
  console.log("Exam Result:", "Fail");
}

const score = 82;

if (score >= 90) {
  console.log("Grade:", "A");
} else if (score >= 75) {
  console.log("Grade:", "B");
} else if (score >= 60) {
  console.log("Grade:", "C");
} else {
  console.log("Grade:", "Fail");
}

const salary = 600000;
let tax;

if (salary <= 250000) {
  tax = 0;
} else if (salary <= 500000) {
  tax = salary * 0.05;
} else {
  tax = salary * 0.2;
}

console.log("Tax Amount:", tax);

const role = "admin";

switch (role) {
  case "admin":
    console.log("Access Level:", "Full Access");
    break;

  case "editor":
    console.log("Access Level:", "Edit Access");
    break;

  case "viewer":
    console.log("Access Level:", "Read Only");
    break;

  default:
    console.log("Access Level:", "No Access");
}