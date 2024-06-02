with open('input_s1_01.txt') as file:
    line = file.readline().split()
    words = []
    for i in line:
        transword = i[:]
        word = ""
        for j in range(len(i)):
            if j % 2 == len(i) % 2:
                word += transword[0]
                transword = transword[1:]
            else:
                word += transword[-1]
                transword = transword[:-1]
        words.append("".join(list(reversed(word))))
    len_words = len(words)
    frase = []
    for i in range(len_words):
        if i % 2 == len_words % 2:
            frase.append(words[0])
            words = words[1:]
        else:
            frase.append(words[-1])
            words = words[:-1]
    print(" ".join(list(reversed(frase))))
