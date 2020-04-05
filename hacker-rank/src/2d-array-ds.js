// Complete the hourglassSum function below.
function hourglassSum(arr) {
    var max = -Infinity; // started with 0 but doesn't account for all values being negative
    var pos = [0,1,2,3]; // we only need to go up to index 3 in either direction
    
    for (let r of pos) {
        for (let d of pos) {
            var sum=arr[r][d]+arr[r][d+1]+arr[r][d+2]+arr[r+1][d+1]+arr[r+2][d]+arr[r+2][d+1]+arr[r+2][d+2]; // very sloppy, is there a cleaner way?
            if (sum > max) {
                max = sum;
            }
        }
    }
    return max;    
}