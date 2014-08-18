<?php
$number = 18;
$isDivided = (($number %2 == 0) && ($number % 9 == 0));
if($isDivided) {
    $isDivided = 'true';
}
else {
    $isDivided = 'false';
}
echo "is $number divided by 2 and 9 at the same time: " . $isDivided;
?>