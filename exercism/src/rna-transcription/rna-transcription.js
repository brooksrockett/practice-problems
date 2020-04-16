//
// This is only a SKELETON file for the 'RNA Transcription' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

// elements broken out into variables
const complements = {'G':'C','C':'G','T':'A','A':'U'}
const map = (c) => complements[c]
const regex = /[GCTA]/g

// updated function
export const toRna = (strand) => strand.replace(regex, map);