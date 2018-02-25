running = 0
while running <= 2000:
    filename = "coords.txt"
    file = open(filename, "r")
    print(file.read())
    running = running + 1
