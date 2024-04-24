a = [0,2,3,5,7,11,13]
num = 15

def check_prime num
	for i in 2...num
		if num%i == 0
			return false
		end
	end	
	return true
end

while a.count <= 10001
	if check_prime(num)
		a.push(num)
		num+=2
	else
		num+=2
	end
end

puts a.last