<?php
    $number = 247;
    if($number < 100) {
        echo("no");
    }
    else {
        for($firstDigit = 1; $firstDigit < 10; $firstDigit++) {
            for($secondDigit = 0; $secondDigit < 10; $secondDigit++) {
                for($thirdDigit = 0; $thirdDigit < 10; $thirdDigit++) {
                    $isUnique = ($firstDigit != $secondDigit) && ($firstDigit != $thirdDigit) && ($secondDigit != $thirdDigit);
                    $concatedNumber = (integer)$firstDigit . $secondDigit . $thirdDigit;
                    if($isUnique == true &&($concatedNumber <= $number)) {
                        echo($concatedNumber . ', ');
                    }
                }
            }
        }
    }
?>