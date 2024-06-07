import math

row = 5
i = math.inf
a = [[0, 1, 2, 3, 4, 5],
     [1, i, 41, 80, 23, 32],
     [2, 41, i, 45, 12, 37],
     [3, 80, 45, i, 50, 64],
     [4, 23, 12, 50, i, 67],
     [5, 32, 37, 64, 67, i]]

weight = 0
paths = []
step = 0
for q in range(row - 2):
    min_row = [min(x[1:]) for x in a[1:]]
    weight += sum(filter(lambda x: x != math.inf, min_row))
    for i in range(row):
        if min_row[i] == math.inf:
            continue
        a[1 + i] = a[1 + i][0:1] + [x - min_row[i] for x in a[i + 1][1:]]

    cols = [[] for x in range(row + 1)]
    for r in a:
        for i, e in enumerate(r):
            cols[i] += [e]
    min_col = [min(col[1:]) for col in cols[1:]]
    weight += sum(filter(lambda x: x != math.inf, min_col))
    a = [[el if i == 0 or rIndex == 0 or min_col[i - 1] == math.inf else el - min_col[i - 1] for i, el in enumerate(row)] for rIndex, row in enumerate(a)]

    zeros = [[(rIndex, colIndex) for colIndex, el in enumerate(row) if el == 0] for rIndex, row in enumerate(a)]
    zeros = [x for xs in zeros for x in xs][1:]

    min_row = [min(sorted(x[1:])[1:]) for x in a[1:]]
    cols = [[] for x in range(row + 1)]
    for r in a:
        for i, e in enumerate(r):
            cols[i] += [e]

    min_col = [min(sorted(col[1:])[1:]) for col in cols[1:]]
    zeros = [(z[0], z[1], min_row[z[0] - 1] + min_col[z[1] - 1]) for z in zeros]  # посчитали степени нулей
    max_zero = max(zeros, key=lambda x: x[2])

    for i in range(1, row + 1):
        a[max_zero[0]][i] = math.inf
    for i in range(1, row + 1):
        a[i][max_zero[1]] = math.inf
        
    a[max_zero[1]][max_zero[0]] = math.inf
    inf_in_row = [len([e for e in row if e == math.inf]) for row in a][1:]
    for int_row, infs in enumerate(inf_in_row):
        if infs == step + 1:
            break
    int_row += 1

    cols = [[] for x in range(row + 1)]
    for r in a:
        for i, e in enumerate(r):
            cols[i] += [e]
    inf_in_col = [len([e for e in col if e == math.inf]) for col in cols][1:]
    for int_col, infs in enumerate(inf_in_col):
        if infs == step + 1:
            break
    int_col += 1

    a[int_row][int_col] = math.inf

    paths.append((max_zero[0], max_zero[1]))
    step += 1

remains = [[(rIndex, cIndex, a[rIndex][cIndex]) for cIndex, el in enumerate(row) if a[rIndex][cIndex] != math.inf and rIndex != 0 and cIndex != 0] for rIndex, row in enumerate(a)]
remains = [x for xs in remains for x in xs]
for i in remains:
    weight += i[2]

paths += [(i[0], i[1]) for i in remains]

final_path = [paths[0][0], paths[0][1]]
paths = paths[1:]

while len(final_path) < row:
    starts = [x for x in paths if x[0] == final_path[-1]][0][1]
    final_path += [starts]
    paths = [x for x in paths if paths[0] != final_path[-1]]
print(weight, final_path)
