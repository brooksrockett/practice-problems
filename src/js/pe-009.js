var a = 0;
var b = 0;
var c = 0;
var result = 0;
var square = function (num) {
    return num * num;
};
for (a = 0; a < 1001; a++) {
    for (b = a + 1; b < 1001; b++) {
        for (c = b + 1; c < 1001; c++) {
            if (square(a) + square(b) == square(c) && a + b + c == 1000) {
                result = a * b * c;
                break;

            }
        }
        if (square(a) + square(b) == square(c) && a + b + c == 1000) {
            result = a * b * c;
            break;
        }
    }
    if (square(a) + square(b) == square(c) && a + b + c == 1000) {
        result = a * b * c;
        break;
    }
}

console.log(result);