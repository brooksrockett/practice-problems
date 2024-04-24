function filterUnique(arr) {
	return arr.filter(e => noRepeats(e))
}

function noRepeats(string) {
  return (string.match(/(.).*\1/g) == null) ? true : false
}