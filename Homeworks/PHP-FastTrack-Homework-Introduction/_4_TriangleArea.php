<?php
$aPointX = 53;
$aPointY = 18;
$bPointX = 56;
$bPointY = 23;
$cPointX = 24;
$cPointY = 27;
$rectArea = abs(($aPointX * ($bPointY - $cPointY) + $bPointX * ($cPointY - $aPointY) + $cPointX * ($aPointY - $bPointY)) / 2);
echo "<h1>Rectangle's area is:<h1>  $rectArea";
?>