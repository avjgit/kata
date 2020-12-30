def to_rna(dna_strand):
    dna_to_rna_rules = {
        "G": "C",
        "C": "G",
        "T": "A",
        "A": "U"
    }

    return ''.join(map(lambda dna_nucleotide: dna_to_rna_rules[dna_nucleotide], dna_strand))
