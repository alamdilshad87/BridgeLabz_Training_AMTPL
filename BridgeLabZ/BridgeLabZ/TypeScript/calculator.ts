type Operator = '+' | '-' | '*' | '/';

function calculate(
  a: number,
  b: number,
  operator: Operator
): number | string {
  switch (operator) {
    case '+': return a + b;
    case '-': return a - b;
    case '*': return a * b;
    case '/': return b === 0 ? "Cannot divide by zero" : a / b;
  }
}

console.log(calculate(20, 4, '*'));
console.log(calculate(10, 0, '/'));
