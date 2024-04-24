var init = 0123456789;
var p0 = 0;
var p1 = 1;
var p2 = 2;
var p3 = 3;
var p4 = 4;
var p5 = 5;
var p6 = 6;
var p7 = 7;
var p8 = 8;
var p9 = 9;
var c0 = p0 * 1000000000;
var c1 = p1 * 100000000;
var c2 = p2 * 10000000;
var c3 = p3 * 1000000;
var c4 = p4 * 100000;
var c5 = p5 * 10000;
var c6 = p6 * 1000;
var c7 = p7 * 100;
var c8 = p8 * 10;
var c9 = p9 * 1;
var sum = p0 + p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9;
var total = c0 + c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9;
var result = init;
var count = 0;

var click = new function(){
    if (sum == 45)
    {
        return true;
    }
    else return false;
};

while (count < 1000000)
{
for (p0=0;p0<10;p0++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p1=0;p1<10;p1++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p2=0;p2<10;p2++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p3=0;p3<10;p3++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p4=0;p4<10;p4++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p5=0;p5<10;p5++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p6=0;p6<10;p6++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p7=0;p7<10;p7++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p8=0;p8<10;p8++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
    for (p9=0;p9<10;p9++)
{
    if (sum == 45 && total > result)
    {
        result = total;
        count++;
    }
}
}
}
}
}
}
}
}
}
}
}

console.log(count + " " + result)