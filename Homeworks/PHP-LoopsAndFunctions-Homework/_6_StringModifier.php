<!DOCTYPE html>
<html>
    <head>
        <title>String modifier</title>
    </head>
    <body>
        <form action="" method="post">
            <input type="text" name="input"/>
            <input type="radio" name="option" id="checkPlaindrome" value="palindrome"/>
            <label for="checkPlaindrome">Check Plaindrom</label>
            <input type="radio" name="option" id="reverseString" value="reverse"/>
            <label for="reverseString">Reverse String</label>
            <input type="radio" name="option" id="split" value="split"/>
            <label for="split">Split</label>
            <input type="radio" name="option" id="hashString" value="hash"/>
            <label for="hashString">Hash String</label>
            <input type="radio" name="option" id="shuffleString" value="shuffle"/>
            <label for="shuffleString">Shuffle String</label>
            <input type="submit" value="Submit"/>
        </form>
        <?php
        if(isset($_POST['input']) && isset($_POST['option'])) {
            $radio = $_POST['option'];
            $string = $_POST['input'];
            if($radio == 'palindrome') {
                $strLength = floor(strlen($string) / 2);
                $isPalindrome = true;
                for($i = 0; $i < $strLength; $i++) {
                    if(!($string[$i] == $string[strlen($string) - $i - 1])) {
                        $isPalindrome = false;
                        break;
                    }
                }
                if($isPalindrome) {
                    $string = htmlentities($string);
                    echo "$string is a palindrome!";
                }
                else {
                    $string = htmlentities($string);
                    echo "$string is not a palindrome!";
                }
            }
            elseif ($radio == 'reverse') {
                $string = htmlentities(strrev($string));
                echo "$string";
            }
            elseif ($radio == 'split') {
                $arrString = [];
                for($i = 0; $i < strlen($string); $i++) {
                    if($string[$i] == '' || $string[$i] == ' ') {
                        continue;
                    }
                    else {
                        $arrString[$i] = $string[$i];
                    }
                }
                $arrString = implode(' ', $arrString);
                echo $arrString;
            }
            elseif ($radio == 'hash') {
                $string = crypt($string);
                echo $string;
            }
            elseif($radio == 'shuffle') {
                $string = str_shuffle($string);
                echo $string;
            }
        }
        ?>
    </body>
</html>