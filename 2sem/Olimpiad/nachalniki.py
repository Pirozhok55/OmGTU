def add_person(num, name):
    persons[num] = name

def find_subordinate(boss, base):
    subordinate = set()
    for y in range(len(base) - 1):
        if y % 2 == 0 and base[y][0] == boss:
            subordinate.add(base[y + 1][0])
    return subordinate

persons = {}
file = open("input_s1_01.txt").readlines()
ID = set([i[:4] for i in file][:-2])
persons_list = []

for i in range(len(f) - 2):
    persons_list.append([file[i][:4], file[i][5:-1]])

for i in ID:
    add_person(i, 'no name')
    for j in persons_list:
        if i == j[0] and j[1] != '':
            add_person(i, j[1])

boss = f[-1]
if not(boss.isdigit()):
    for i in persons_list:
        if i[1] == boss:
            boss = i[0]
            break

boss_subordinate = find_subordinate(master, persons_list)

add_subordinate = set()
while True:
    lens = len(boss_subordinate)
    for u in boss_subordinate:
        add_subordinate = add_subordinate.union(find_subordinate(u, persons_list))
    boss_subordinate = boss_subordinate.union(add_subordinate)
    if len(boss_subordinate) == lens:
        break

boss_subordinate = sorted(boss_subordinate)
if boss_subordinate == set():
    print("NO")
else:
    for i in boss_subordinate:
        print(i, persons[i])
