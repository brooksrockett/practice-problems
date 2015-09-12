def Exp(x,y)
result = 1
for i in 1..y
result *= x
end
return result
end

count = 0
for n in 1..10
for e in 1..100
if e == Exp(n,e).to_s.length
count+=1
end
end
end
puts count