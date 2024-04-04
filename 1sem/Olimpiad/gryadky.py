#решение формулой
l, m, n, k = 7, 10, 5, input('Введите количество грядок: k = ')
int(k)
g = int(k)
if g>=0:
    s = g*(2*(l+m+n)+(g-1)*m)
print('Результат: s = ', s)


#решение циклом
s, l, m, n, k = 0, 7, 10, 5, input('Введите k = ')
int(k)
g = int(k)
while g != 0:
    r = 2*(l+n+g*m)
    s += r
    g -= 1
print('Результат: s = ', s)
