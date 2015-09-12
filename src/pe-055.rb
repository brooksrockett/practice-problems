def lychrel n, i, o
	rn = n.to_s.reverse.to_i
	s = n+rn
	rs = s.to_s.reverse.to_i
	if i > 50
		return true
	elsif s == rs
		return false
	else
		lychrel(s, i+1, o)	
	end
end

sum = 0

(1..10000).each do |i|
	if lychrel(i,0,i)
		sum+=1
	end
end
puts lychrel(10677,50,10677)
puts lychrel(47,50,47)
puts sum