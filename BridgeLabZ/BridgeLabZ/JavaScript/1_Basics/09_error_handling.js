function divide(a, b) {
  if (b === 0) {
    throw new Error("Division by zero");
  }
  return a / b;
}

try {
  const result = divide(10, 2);
  console.log("Division Result:", result);
} catch (error) {
  console.log("Error:", error.message);
}

try {
  divide(10, 0);
} catch (error) {
  console.log("Error:", error.message);
}

function parseInput(value) {
  const num = Number(value);

  if (Number.isNaN(num)) {
    throw new Error("Invalid number input");
  }

  return num;
}

try {
  const parsed = parseInput("123");
  console.log("Parsed Number:", parsed);
} catch (error) {
  console.log("Parse Error:", error.message);
}

try {
  parseInput("abc");
} catch (error) {
  console.log("Parse Error:", error.message);
}