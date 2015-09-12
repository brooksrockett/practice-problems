x = 13195

def find_factors num
	factors = []
	if num%2 == 0
		num/=2
	end
	for i in 2...num
		if num%i == 0
			factors.push(i)
		end
	end	
	return factors
end

def check_prime primeno
	if find_factors(primeno)==[]
		return true
	else
		return false
	end
end

#find_factors(13195).reverse_each do |factor|
find_factors(600851475143).reverse_each do |factor|
	if check_prime(factor)
		puts factor
	end
end