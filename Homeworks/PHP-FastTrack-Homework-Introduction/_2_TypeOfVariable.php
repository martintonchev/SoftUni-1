<?php
$someInteger = 5;
$someDouble = 2.1;
$someString = 'Traqn';
$someBoolean = true;
$someArray = [1, 23, 545, 5, 34];
$null = null;
echo "$someInteger is of type" . gettype($someInteger) . '<br/>';
echo "$someDouble is of type" .gettype($someDouble) . '<br/>';
echo "$someString is of type" .gettype($someString) . '<br/>';
echo "$someBoolean is of type" .gettype($someBoolean) . '<br/>';
echo "$someArray[0] is of type" .gettype($someArray) . '<br/>';
echo gettype($null);
var_dump($someInteger);
var_dump($someDouble);
var_dump($someString);
var_dump($someBoolean);
var_dump($someArray);
var_dump($null);
?>