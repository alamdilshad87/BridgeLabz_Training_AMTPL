function scopeTest() {
  if (true) {
    let a = 10;
    const b = 20;
    var c = 30;
  }

  console.log("var c:", c);
}

scopeTest();

function hoistingVar() {
  console.log("var before:", x);
  var x = 5;
  console.log("var after:", x);
}

hoistingVar();

function hoistingLet() {
  try {
    console.log(y);
  } catch (e) {
    console.log("let error:", e.message);
  }

  let y = 10;
  console.log("let after:", y);
}

hoistingLet();

function loopScopeVar() {
  for (var i = 0; i < 3; i++) {}
  console.log("var loop i:", i);
}

loopScopeVar();

function loopScopeLet() {
  for (let j = 0; j < 3; j++) {}
  try {
    console.log(j);
  } catch (e) {
    console.log("let loop error:", e.message);
  }
}

loopScopeLet();