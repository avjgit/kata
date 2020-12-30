def leap_year(year):
    def is_evenly_divisible_by(number):
        return year % number == 0

    if is_evenly_divisible_by(400):
        return True

    if is_evenly_divisible_by(100):
        return False

    return is_evenly_divisible_by(4)
