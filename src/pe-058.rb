require 'prime'

# start at "9" square
i = 9
# side length
x = 4
# primes counted (numerator)
n = 3.0
# total corners (denominator)
d = 5.0
# solution timer
t1 = Time.now()

# infinite loop until broken
while true
	# iterate 4 times for 4 corners
	(1..4).each do
		# add sidelength for corner-to-corner
		i += x
		# increase corner count
		d += 1
		# if corner is prime, increment numerator
		if Prime.prime?(i)
			n += 1
		end
	end
	# if the ratio of primes to total corners drops below 10% (0.10), break loop and report
	if (n/d < 0.10)
		t2 = Time.now()
		puts "\nlast corner: " + i.to_s
		puts 'side length: ' + (x+1).to_s
		puts 'ratio: ' + (n/d).to_s
		puts 'time taken: ' + (t2-t1).to_s
		break
	end
	# if loop hasn't broken, increase sidelength by 2 before looping
	x += 2
end
