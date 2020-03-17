x = 1
y = 2
total = 0
counter = 3
result = ''
while len(result)<1000:
	total = x+y
	x = y
	y = total
        result = str(total)
        counter += 1
print 'Resulting term: ' + str(result)
print 'Fibonacci number of term: ' + str(counter)