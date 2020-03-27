function strCount(str, letter){  
    var sum = 0;
    for (var l of str) {
        if (l === letter) {
            sum++;
        }
    }
    return sum;
}