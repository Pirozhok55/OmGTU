file = open('input7.txt')
with file:
    lines = [line.strip() for line in file.readlines()]
result = []
operations = { 'MIX': 'MX', 'WATER': 'WT', 'DUST': 'DT', 'FIRE': 'FR', }

for ing, command in enumerate(lines):
    oper, *ins = command.split(' ')
    ingred = ''
    for i in ins:
        if i.isdigit():
            ingred += result[int(i) - 1]
        else:
            ingred += i
    ingred = operations[oper] + ingred + operations[oper][::-1]
    result.append(ingred)
print(result[-1])
