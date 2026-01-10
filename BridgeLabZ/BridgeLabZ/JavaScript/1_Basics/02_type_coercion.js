console.log(5 + "5");
console.log("10" - 2);
console.log("10" * 2);
console.log("10" / 2);

// Why this happens:
// + prefers string concatenation
// -, *, / force numeric conversion

// Boolean coercion
console.log(Boolean(0));
console.log(Boolean(1));
console.log(Boolean(""));
console.log(Boolean("JS"));
console.log(Boolean(null));
console.log(Boolean(undefined));

console.log(5 == "5");
console.log(5 === "5");

// null vs undefined
console.log(null == undefined);
console.log(null === undefined);

// Numeric edge cases
console.log(Number("abc"));
console.log(typeof NaN);
console.log(NaN === NaN);

// Safe checks
console.log(isNaN("abc"));
console.log(Number.isNaN("abc"));
console.log(Number.isNaN(NaN));

