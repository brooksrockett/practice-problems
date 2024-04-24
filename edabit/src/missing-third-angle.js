function missingAngle(angle1, angle2) {
	angle3 = 180-(angle1+angle2)
	if (angle3 == 90) {return 'right'}
	else if (angle3 < 90) {return 'acute'}
	else return 'obtuse'
}