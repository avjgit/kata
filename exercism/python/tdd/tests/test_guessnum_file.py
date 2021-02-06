from guessnum_folder.guessnum import Guessnum


def test_guess():
    assert Guessnum().guess() == 42
