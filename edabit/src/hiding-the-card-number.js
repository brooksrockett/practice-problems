function cardHide(card) {
	const fourIndex = card.length-4
	const lastFour = card.substr(fourIndex,4)
	const newCard = Array(fourIndex).fill('*').join('')
	return newCard+lastFour
}