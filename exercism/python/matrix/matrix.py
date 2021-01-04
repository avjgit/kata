class Matrix:
    rows = []

    def __init__(self, matrix_string):
        self.rows = []
        for line in matrix_string.splitlines():
            self.rows.append([int(x) for x in line.split()])

    def row(self, index):
        return self.rows[index - 1]

    def column(self, index):
        column = []
        for row in self.rows:
            column.append(row[index - 1])
        return column
