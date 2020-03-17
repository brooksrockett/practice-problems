number = 100

def sum_of_squares number
	sum = 0
	for i in 1..number
		sum+=i*i
	end
return sum
end

def square_of_sums number
	sum = 0
	for i in 1..number
		sum+=i
	end
return sum*sum
end

sos1 = sum_of_squares(number)
sos2 = square_of_sums(number)


puts 'Sum of squares: ' + sos1.to_s
puts 'Square of sums: ' + sos2.to_s
puts
puts 'Final answer: ' + (sos2-sos1).to_s