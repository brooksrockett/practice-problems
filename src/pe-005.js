function allDivisible(num,div) {
    for (i=1;i<=div;i++) {
        if (num%i != 0) {
            return false;
        }
    }
    return true;
}

x=20;
y=20;

while (true) {
    if (allDivisible(x,y)){
        break;
    }
    x+=20;
    continue;
}

console.log(x);