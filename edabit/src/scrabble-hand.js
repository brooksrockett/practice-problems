function maximumScore(tileHand) {
	return tileHand.map(e=> e.score).reduce((a,b) => a+b)
}