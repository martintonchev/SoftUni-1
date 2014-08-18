<!DOCTYPE html>
<html>
    <head>
        <title>Numbers from 1 to n</title>
    </head>
    <body>
        <form action="" method="get">
            <label for="num">Please enter a number: </label>
            <input type="text" name="number" id="num"/>
            <input type="submit"/>
        </form>
        <?php
        if(isset($_GET['number'])) {
            $number = (int)$_GET['number'];
        }
        for($i = 1; i < $number; $i++) {
            echo $i;
        }
        ?>
    </body>
</html>