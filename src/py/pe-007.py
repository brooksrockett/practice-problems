import math

def Prime(num):
	high = round(math.sqrt(num))
	for i in range(2, num):
		if (num%i==0):
			return False

	#else return true
	return True

#Find Prime
def FindPrime(ending):
	primes = [2]
	i = 3
	while True:
		if (Prime(i)):
			primes.append(i)
			if len(primes) == ending:
				print(primes.pop())
				break
		#Increment
		i += 2

#Process
FindPrime(10001)