highest = 0

# checks a number for palindromity(?)
def palindrome_check number
	if number.to_s == number.to_s.reverse
		return true
	else
		return false
	end
end

# multiply all three digit numbers starting at 999*999
for i in (100..999).reverse_each
	for j in (100..999).reverse_each
		num = i*j
		if num >= highest && palindrome_check(num)
			highest = num
		end
	end
end

puts highest