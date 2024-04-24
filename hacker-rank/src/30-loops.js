function main() {
    const n = parseInt(readLine(), 10);
    for (let i of Array(10).keys()) {
        console.log(`${n} x ${i+1} = ${n*(i+1)}`);
    }
}