fn main() {
    let mut sum = 0;
    let max = 1000;
    let mut i = 1;
    while i < max {
        if i%3 == 0 || i%5 == 0 {
            sum+=i;
        }
        i+=1;
    }
    eprint!("Sum of all multiples of 3 or 5 below {}: {}", max, sum);
}
