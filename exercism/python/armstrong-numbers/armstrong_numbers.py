def is_armstrong_number(number):
    digits = [int(i) for i in list(str(number))]
    power = len(digits)
    return number == sum([i ** power for i in digits])
