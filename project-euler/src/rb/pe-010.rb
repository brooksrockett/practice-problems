require 'benchmark'
require 'mathn'

puts Benchmark.measure {
sum = 0
Prime.each do |prime|
	if prime > 2000000
		break
	else
		sum+=prime
	end
end

puts sum
}