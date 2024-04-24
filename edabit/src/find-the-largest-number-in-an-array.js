function findLargestNum(arr) {
	return arr.sort((a,b) => a-b).reverse()[0]
}