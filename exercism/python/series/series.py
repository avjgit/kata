def slices(series, length):
    if not series:
        raise ValueError("Should pass non-empty series")

    if length <= 0:
        raise ValueError("Should pass positive slice length")

    if length > len(series):
        raise ValueError("Should pass slice not longer than series")

    series_list = []
    i = 0
    while True:
        series_list.append(series[i:i+length])
        if i + length >= len(series):
            break
        i += 1
    return series_list
