maxN = int(input())
comb = 0
for n in range(1, maxN + 1):
    for i in range(2, 18):
        if n % (2 ** i - 1) == 0:
            comb += 1
print(maxN + comb)
