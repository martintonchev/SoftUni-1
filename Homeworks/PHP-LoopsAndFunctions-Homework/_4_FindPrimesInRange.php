<!DOCTYPE html>
<html>
    <head>
        <title>Find primes in range</title>
    </head>
    <body>
        <form action="" method="post">
            <label for="startIndex">Starting Index: </label>
            <input type="number" name="startIndex" id="startIndex"/>
            <label for="endIndex">End:</label>
            <input type="number" name="endIndex" id="endIndex"/>
            <input type="submit" value="Submit"/>
        </form>
        <?php
        if(isset($_POST['startIndex']) && isset($_POST['endIndex'])) {
            $start = $_POST['startIndex'];
            $end = $_POST['endIndex'];
            for($i = $start; $i <= $end; $i++) {
                $isPrime = true;
                for($j = 2; $j < $i; $j++) {
                    if($i % $j == 0) {
                        $isPrime = false;
                    }
                }
                if($isPrime) {
                    if($i == $end) {
                        $delimiter = "";
                    }
                    else {
                        $delimiter = ", ";
                    }
                ?>
                    <span><strong><?= $i?></strong><?= $delimiter?></span>
                <?php
                }
                else {
                    if($i == $end) {
                        $delimiter = "";
                    }
                    else {
                        $delimiter = ", ";
                    }
                ?>
                    <span><?= $i . $delimiter?></span>
                <?php
                }
            }
        }
        ?>
    </body>
</html>