// Complete the solve function below.
function main() {
    const N = parseInt(readLine(), 10);
    const w = 'Weird';
    const nw = 'Not Weird';
    if (!(N % 2 === 0)) {console.log(w);}
    else if (N >= 2 && N <= 5) {console.log(nw);}
    else if (N >= 6 && N <= 20) {console.log(w);}
    else if (N > 20) {console.log(nw);}
}
