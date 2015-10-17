def Prime(num)
	high = Math.sqrt(num)+1
	(2...high).each do |i|
		if num%i == 0
			return false
		end
	end
	return true
end


def FindPrime(ending)
	primes = [2]
	i = 3
	while true do
		if (Prime(i))
			primes.push(i)
			if primes.count == ending
				puts primes.last
				break
			end
		end
		i+=2
	end
end

FindPrime(10001)