#решение циклом

s, l, m, n, k = 0, 7, 10, 5, input('Введите k = ')
try:
    int(k)
    g = int(k)
    if g >= 0:
        while g != 0:
            r = 2*(l+n+g*m)
            s += r
            g -= 1
        print('Результат: s = ', s)
    else:
        print('Число не корректно!')
except ValueError:
    print('Число не корректно!')