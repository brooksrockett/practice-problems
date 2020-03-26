var i = 0;
var sum = 0;
var str = "";
var numberNames = function(n)
{
    var digit = String(n)[0];
    var digit2 = String(n)[1];
    if (n < 10)
    {
    if (n == 9 || n == 5 || n == 4)
    {
        return 4;
   } 
    else if (n == 8 || n == 7 || n == 3)
    {
        return 5;
    }
    else if (n == 6 || n == 2 || n == 1)
    {
        return 3;
    }
    else if (n === 0 || n === "0")
    {
        return 0;
    }
    }
    else if (n>=10 && n<20)
    {
        if (n == 19)
        {
            return "nineteen".length;
        }
        
        if (n == 18)
        {
            return "eighteen".length;
        }
        
        if (n == 17)
        {
            return "seventeen".length;
        }
        
        if (n == 16)
        {
            return "sixteen".length;
        }
        
        if (n == 15)
        {
            return "fifteen".length;
        }
        if (n == 14)
        {
            return "fourteen".length;
        }
        
        if (n == 13)
        {
            return "thirteen".length;
        }
        
        if (n == 12)
        {
            return "twelve".length;
        }
        
        if (n == 11)
        {
            return "eleven".length;
        }
        
        if (n == 10)
        {
            return "ten".length;
        }
    }
    else if (n>=20 && n<100)
    {
        if (digit==9 || digit==8 || digit==3 || digit==2)
        {
            return numberNames(digit2)+6;
        }
        else if (digit==7)
        {
            return numberNames(digit2)+7;
        }
        else
        {
            return numberNames(digit2)+5;
        }
    }
};

for (i=1;i<=1000;i++)
{
    str = String(i);
    num = i;
    while (num !== 0)
    {
    if (num == 1000)
    {
        sum += "onethousand".length;
        num = 0;
    }
    else if (num < 1000 && num >= 100)
    {
        if (num % 100 === 0)
        {
        sum += "hundred".length;
        sum += numberNames(str[0]);
        num -= Number(str[0])*100;    
        }
        else
        {
        sum += "hundredand".length;
        sum += numberNames(str[0]);
        num -= Number(str[0])*100;
        }
    }
    else
    {
        sum += numberNames(num);
        num = 0;
    }
    }
}
console.log(sum);