let i = 1;

while (i <= 3) {
  console.log("While Count:", i);
  i++;
}

for (let j = 1; j <= 5; j++) {
  console.log("For Count:", j);
}

let sum = 0;

for (let k = 1; k <= 5; k++) {
  sum += k;
}

console.log("Total Sum:", sum);

for (let n = 1; n <= 10; n++) {
  if (n % 2 === 0) {
    console.log("Even Number:", n);
  }
}

for (let x = 1; x <= 5; x++) {
  if (x === 3) {
    break;
  }
  console.log("Break Example:", x);
}

for (let y = 1; y <= 5; y++) {
  if (y === 3) {
    continue;
  }
  console.log("Continue Example:", y);
}