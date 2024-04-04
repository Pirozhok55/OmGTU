a = open('input7.txt')
cmlist = []
for line in a:
    listN = list(map(float, line.split()))
    if len(listN) == 1:
        continue
    s1 = 2 * (listN[0] * listN[1] + listN[0] * listN[2] + listN[1] * listN[2])
    s2 = 2 * (listN[3] * listN[4] + listN[3] * listN[5] + listN[5] * listN[4])
    v1 = listN[0] * listN[1] * listN[2]
    v2 = listN[3] * listN[4] * listN[5]
    cm = (listN[6] - (s1 * listN[7]) / s2) / (v1 - (s1 * v2) / s2)
    cmlist.append(cm)
minimal = min(cmlist)
print(str(cmlist.index(minimal) + 1), abs(round((minimal * 1000), 2)))
