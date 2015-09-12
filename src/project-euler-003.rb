def IsPrime(x)
for i in 3..Math.sqrt(x)
if x%i==0
return false
end
return true
end
end

x = 600851475143
for i in (1..Math.sqrt(x)).to_a.reverse
if x%i == 0 && IsPrime(i)
puts i
break
end
end


