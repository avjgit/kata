import random


class Robot:

    @staticmethod
    def repeat_times(function, times):
        result = ''
        for _ in range(times):
            result += function()
        return result

    @staticmethod
    def generate_name():
        random.seed()
        def random_char(): return chr(random.randint(ord('A'), ord('Z')))
        def random_int(): return str(random.randint(1, 9))
        return Robot.repeat_times(random_char, 2) + Robot.repeat_times(random_int, 3)

    def __init__(self):
        self._name = self.generate_name()

    @property
    def name(self):
        if not self._name:
            self._name = self.generate_name()

        return self._name

    @name.setter
    def name(self, value):
        self._name = value

    def reset(self):
        self._name = ''
