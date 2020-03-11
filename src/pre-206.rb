a = 1020304050607080900
b = 1929394959697989990
x = Math.sqrt(a).floor.round(-1)
y = Math.sqrt(b).ceil.round(-1)

while x < y
  z = x * x
  s = z.to_s
  if a...b === z
    if s[0] != '1' || s[2] != '2' || s[4] != '3' || s[6] != '4' || s[8] != '5' || s[10] != '6' || s[12] != '7' || s[14] != '8' || s[16] != '9' || s[18] != '0'
      x += 10
      next
    else
      puts x
      puts z
      break
    end
  end
  x += 10
  next
end
