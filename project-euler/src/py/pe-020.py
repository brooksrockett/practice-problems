x = 1
for i in range (1,101):
    x = x * i

result = str(x)
length = len(result)-1

print "Result: " + str(result) 
print "Number of Digits: " + str(length)
final = 0

for i in range (0,length+1):
    w = int(result[i])
    final = final + w

print "Sum of digits: " + str(final)