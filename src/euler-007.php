<?php

function Prime($num) {
	$high = round(sqrt($num));
	if ($high >= 2) {
		foreach (range(2, $high) as $i) {
			if ($num%$i == 0) {
				return false;
			}
		}
	}
	return true;
}

function FindPrime($ending) {
	$primes = array(2);
	$i = 3;
	while (true) {
		if (Prime($i)) {
			array_push($primes, $i);
			if (count($primes) == $ending) {
				echo end($primes);
				break;
			}
		}
		$i+=2;
	}
}

FindPrime(10001);

?>