alien = Actor('alien')
alien.pos = 10, 10

WIDTH = 500
HEIGHT = alien.height + 20


def draw():
    screen.clear()
    alien.draw()


