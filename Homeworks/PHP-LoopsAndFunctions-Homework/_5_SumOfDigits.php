<!DOCTYPE html>
<html>
    <head>
        <title>Sum of digits</title>
    </head>
    <body>
        <form action="" method="post">
            <label for="inputString">Input strng: </label>
            <input type="text" name="inputString" id="inputString"/>
            <input type="submit" value="Submit"/>
        </form>
        <table border="1">
            <tr>
                <th>Value</th>
                <th>Sum</th>
            </tr>
        <?php
        if(isset($_POST['inputString'])) {
            $inputString =
            $inputArray = explode(', ', $_POST['inputString']);
            foreach ($inputArray as $value) {
                $curValue = intval($value);
                if($curValue == 0) { ?>
                    <tr>
                        <td><?= $value ?></td>
                        <td><span>I cannot sum that</span></td>
                    </tr>
                <?php
                }
                else {
                    $firstDigit = $curValue % 10;
                    $curValue = floor($curValue / 10);
                    $secondDigit = $curValue % 10;
                    $curValue = floor($curValue / 10);
                    $thirdDigit = $curValue % 10;
                    $curValue = floor($curValue / 10);
                    $forthDigit = $curValue;
                    $sum = $firstDigit + $secondDigit + $thirdDigit + $forthDigit;
                    ?>
                    <tr>
                        <td><?= $value ?></td>
                        <td><?= $sum ?></td>
                    </tr>
                <?php
                }
            }
        }
        ?>
        </table>
    </body>
</html>