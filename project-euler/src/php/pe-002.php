<?php
$x=1;
$y=2;
$z=3;
$sum=2;
while ($z<4000000) {
    if ($z % 2 ==0) {
    $sum+=$z;
    }
    $x=$y;
    $y=$z;
    $z=$x+$y;
}
echo $sum;
?>