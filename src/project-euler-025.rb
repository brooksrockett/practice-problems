x = 1
y = 2
total = 0
counter = 3
result = ""
while result.length<1000
	total = x+y
	x = y
	y = total
        result = String(total)
        counter += 1
end
puts "Resulting term: #{String(result)}"
puts "Fibonacci number of term: #{String(counter)}"