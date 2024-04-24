function reverseNumber(num) {
    return Number(num.toString().split("").reverse().join(""));
}

max=0;
for (x=100;x<1000;x++) {
    for (y=100;y<1000;y++) {
        p=x*y;
        r=reverseNumber(p);
        if (p==r && p>max) {
            max=p;
        }
    }
}

console.log(max);