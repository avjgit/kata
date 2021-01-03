def convert(number):
    factor_sounds = {
        3: 'Pling',
        5: 'Plang',
        7: 'Plong'
    }

    raindrops = ''
    for factor, sound in factor_sounds.items():
        raindrops += sound if number % factor == 0 else ''

    return raindrops if raindrops else str(number)
