a = []
ans = 1


for i in 1..1000
	a[i] = (i*i)
end

for j in 0...a.count
	for k in 0..a.count
		sum = (a[j].to_i + a[k].to_i)
		loc = a.find_index(sum)
		if (loc && (j + k + loc == 1000))
			currans = j * k * loc
			if currans > ans
				ans = currans
				break
			end
		end
	end
end

puts ans