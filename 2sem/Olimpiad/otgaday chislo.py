file = open('input_s1_01.txt')
with file:
    proc = [0, 1]
    line = file.readline()
    for i in range(int(line)):
        oper, number = file.readline().strip().split()
        if number == 'x':
            if oper == '+':
                proc[1] += 1
            elif oper == '-':
                proc[1] -= 1
        else:
            if oper == '+':
                proc[0] += int(number)
            elif oper == '-':
                proc[0] -= int(number)
            elif oper == '*':
                proc[0] *= int(number)
                proc[1] *= int(number)
    prew = int(file.readline())
result = (prew - proc[0]) / proc[1]
print(int(result))
