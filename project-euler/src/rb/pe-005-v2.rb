def checkDivisors(num)
	yes = false
	for i in 1..20
		if num % i != 0
			return false
		end
	end
	print "Result: "
	return true
end


num = 2520
while true
	if checkDivisors(num)
		break
		else
	end
	num+=20
end
puts num