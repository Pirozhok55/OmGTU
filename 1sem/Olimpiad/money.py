a = [int(x) for x in input().split()][1:] 
aSort = sorted([int(x) for x in input().split()][1:], reverse=True)
b = [int(x) for x in input().split()][1:] 
bSort = sorted([int(x) for x in input().split()][1:])
money = [int(x) for x in input().split()]
realMoney = 0

for index, n in enumerate(money):
    for i in aSort:
        if n > i:
            n -= 1
    for i in a[index:]:
        n *= i
    realMoney += n
    
c = []
for i in reversed(b):
    c += [realMoney % i]
    realMoney //= i
    
c += [realMoney]
for index, n in enumerate(c):
    for i in bSort:
        if n >= i:
            n += 1
    c[index] = n

for i in reversed(c):
    print(i, end=" ")
