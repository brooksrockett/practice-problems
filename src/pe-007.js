function checkPrime(num) {
    for (x=2;x<num/2;x++) {
        if (num%x==0) {
            return false;
        }
    }
    return true;
}

num=1;
i=1;
while (num<10001) {
    i+=2;
    if (checkPrime(i)) {
        num++;
    }
}
console.log(num);
console.log(i);