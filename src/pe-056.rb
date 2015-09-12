hun = (1..100)
$max = 0

hun.each do |i|
	hun.each do |j|
		a = (i**j).to_s.split('')
		sum = 0
		a.each do |x|
			sum += x.to_i
		end
		if sum > $max
			$max = sum
		end
	end
end

puts $max
