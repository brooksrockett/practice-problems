# initialize array and sum
a = [1,2]
sum = 0

while a.last <= 4000000
	# check if last num in a is even
	if a.last%2 == 0
		# if so, add to sum
		sum+=a.last
	end
	# add sum of last two array objects to end of array
	a.push(a.last.to_i + a[a.count-2].to_i)
end

puts sum