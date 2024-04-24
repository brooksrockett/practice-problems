function getAbsSum(arr) {
	arr = arr.map(e => Math.abs(e))
	return arr.reduce((a, b) => a + b,0)
}