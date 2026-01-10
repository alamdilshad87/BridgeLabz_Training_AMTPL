let a = 10;
let b = a;

b = 20;

console.log("Value Type a:", a);
console.log("Value Type b:", b);

const arr1 = [1, 2, 3];
const arr2 = arr1;

arr2.push(4);

console.log("Array arr1:", arr1);
console.log("Array arr2:", arr2);

const obj1 = { name: "Dilshad", score: 40 };
const obj2 = obj1;

obj2.score = 50;

console.log("Object obj1:", obj1);
console.log("Object obj2:", obj2);

const arr3 = [10, 20];
const arr4 = [...arr3];

arr4.push(30);

console.log("Copied Array arr3:", arr3);
console.log("Copied Array arr4:", arr4);

const obj3 = { city: "Delhi", pin: 110001 };
const obj4 = { ...obj3 };

obj4.pin = 560001;

console.log("Copied Object obj3:", obj3);
console.log("Copied Object obj4:", obj4);