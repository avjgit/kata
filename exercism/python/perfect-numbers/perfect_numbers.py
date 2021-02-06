def get_factors(number):
    if number == 1:
        return []

    factors = [1]
    for n in range(2, number // 2):
        if number % n == 0:
            factors.append(n)
            factors.append(number / n)

    return set(factors)


def classify(number):
    if not number > 0:
        raise ValueError("must be positive (not you, but the number")

    factors_sum = sum(get_factors(number))

    if factors_sum > number:
        return "abundant"
    if factors_sum < number:
        return "deficient"
    return "perfect"


print(get_factors(32))