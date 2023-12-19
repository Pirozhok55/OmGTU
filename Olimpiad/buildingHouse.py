a = open('input_s1_01.txt')
x, y, l, c1, c2, c3, c4, c5, c6 = map(int, a.read().split())
p = 2 * (x + y)
m = max(x, y)
cb = c4 + c5 + c6
k1 = min(c1, c2 + c3, c2 + cb)
if l <= m:
    cost = (p - l) * (c4 + c5) + l * k1
elif l > p:
    k3 = min(c3, cb)
    cost = (l - p) * (c2 + c6) + (p - m) * (k3 + c2) + m * k1
else:
    k2 = min(c3, cb)
    cost = (p - l) * (c4 + c5) + (l - m) * (k2 + c2) + m * k1
print(cost)
