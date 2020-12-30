def is_pangram(sentence):
    sentence_case_insensitive = sentence.lower()
    for character in "abcdefghijklmnopqrstuvwxyz":
        if character not in sentence_case_insensitive:
            return False
    return True
