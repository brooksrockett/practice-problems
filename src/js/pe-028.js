var c4=1;
var grp=2;
var sum=1;
for (i=2; grp<=501; i=i+2)
{
    c1 = c4 + i;
    c2 = c1 + i;
    c3 = c2 + i;
    c4 = c3 + i;
    sum = sum + c1 + c2 + c3 + c4;
    
grp++;
}
console.log(first);
console.log(last);
console.log(sum);