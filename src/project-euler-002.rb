x=1
y=2
total=2
z=x+y
while z<4000000
if z%2==0
total+=z
end
x=y
y=z
z=x+y
end
puts total