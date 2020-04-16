// Complete the compareTriplets function below.
function compareTriplets(a, b) {
    var c=[0,0];
    for (var i=0;i<3;i++) {
        if (a[i] > b[i]) {
            c[0]++;
        }
        else if (b[i] > a[i]) {
            c[1]++;
        }
        else {}
    }
    return c;
}
