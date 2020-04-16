function changeTypes(arr) {
	arr2 = []
	for (let e of arr) {
		let type = typeof(e)
		if (type == 'number' && e%2== 0) {arr2.push(e+1)}
		else if (type == 'number') {arr2.push(e)}
		else if (type == 'boolean') {arr2.push(!e)}
		else if (type == 'string') {
			arr2.push(e[0].toUpperCase() + e.substr(1,e.length) + '!')
		}
	}
	return arr2
}