from datetime import date
file = open('input_s1_01.txt')
a = file.read().split()
start = list(map(int, a[0].split('.')))
end = list(map(int, a[1].split('.')))
number = int(a[2])
d0 = date(start[2], start[1], start[0])
d1 = date(end[2], end[1], end[0])
days = (d1 - d0).days + 1
result = ((days-1) / 2 + number) * days
print(int(result))
