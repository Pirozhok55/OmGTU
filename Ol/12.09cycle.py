#решение формулой
l, m, n, k = 7, 10, 5, input('Введите количество грядок: k = ')
try:
    int(k)
    g = int(k)
    if g>=0:
        s = g*(2*(l+m+n)+(g-1)*m)
        print('Результат: s = ', s)
    else:
        print('Число не корректно!')
except ValueError:
    print('Число не корректно!')
