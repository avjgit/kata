def is_valid(isbn):
    isbn_length = 10
    normalized_isbn = isbn.replace('-', '')

    if len(normalized_isbn) != isbn_length:
        return False

    if 'X' in normalized_isbn[:-1]:
        return False

    try:
        isbn_digits = [10 if x == 'X' else int(x) for x in normalized_isbn]
    except:
        return False

    checksum = 0
    for i, digit in enumerate(isbn_digits):
        checksum += digit * (isbn_length-i)

    return checksum % 11 == 0
