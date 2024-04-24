number = 2520

# true only if number is divisible by 1-20
def divisible number
	(2..20).each do |i|
		if number%i != 0
			return false
		end
	end
	return true
end

# keep checking each number + 20 until divisible returns true
while true
	if divisible(number) == false
		number+=20
	else
		break
	end
end

puts number