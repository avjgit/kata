def convert(number):
    def divides_by(factor):
        return number % factor == 0

    factor_sounds = {
        3: 'Pling',
        5: 'Plang',
        7: 'Plong'
    }

    factors = {}
    for factor in factor_sounds:
        factors[factor] = divides_by(factor)

    if not any(factors.values()):
        return str(number)

    raindrops = ''
    for factor in factors:
        if factors[factor]:
            raindrops += factor_sounds[factor]

    return raindrops
