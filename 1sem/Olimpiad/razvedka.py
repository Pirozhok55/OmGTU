import math

def razved(n):
    if n == 3:
        return 1
    if n < 3:
        return 0
    else:
        even = math.floor(n/2)
        odd = math.floor(n/2) + (n%2)
        return razved(even) + razved(odd)
    
n = int(open('input_s1_01.txt').readline())
print(razved(n))
