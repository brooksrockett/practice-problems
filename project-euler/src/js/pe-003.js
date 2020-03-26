function checkPrime(num) {
    for (x=2;x<num;x++) {
        if (num%x==0) {
            return false;
        }
    }
    return true;
}

function checkFactor(num, factor) {
    if (num%factor==0) {
        return true;
    }
    return false;
}

function largestPrime(num) {
    numroot = Math.floor(Math.sqrt(num));
    for (i=numroot;i>0;i--) {
        if (checkFactor(num, i) && checkPrime(i)) {
            return i;
        }
    }
    return false;
}

console.log(largestPrime(600851475143));