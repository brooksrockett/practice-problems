function main() {
    const n = parseInt(readLine(), 10);
    const bin = convertBinary(n, []);
    // join [11,0,1] to '1101', split again on 0 = [11,1], sort = [1,11], pop last element '11' and return length: 2
    console.log(bin.join('').split(0).sort().pop().length)
}

function convertBinary(n, arr) {
    while (n >= 1) {
    arr.push(n%2)
    n= Math.floor(n/2)
    }
    return arr
}