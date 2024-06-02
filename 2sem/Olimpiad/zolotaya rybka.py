file = open('input_s1_05.txt')
with file:
    n = int(file.readline().strip())
    words = [file.readline().strip() for _ in range(n)]
    f = int(file.readline().strip())
    bfirst = [file.readline().strip() for _ in range(f)]
    l = int(file.readline().strip())
    blast = [file.readline().strip() for _ in range(f)]

start = []
for i in bfirst:
    for j in range(1, int(i[2:]) + 1):
        start.append(i[0])
end = []
for i in blast:
    for j in range(1, int(i[2:]) + 1):
        end.append(i[0])
count = 0
for i in words:
    if ((i[0] in start) and (i[-1] in end)):
        count += 1
        start.remove(i[0])
        end.remove(i[-1])
print(count)
