<!DOCTYPE html>
<html>
    <head>
        <title>Rectangle's area</title>
    </head>
    <body>
        <form action="" method="post">
            <label>Please enter rectangle's side</label><be/>
            <input name="rectSide" type="text"/><br/>
            <input type="submit" value="Calculates"/><br/>
        </form>
    </body>
</html>
<?php
    $side = $_POST['rectSide'];
    $side = (int)$side;
    echo "The rectangles area is: " . $side * $side;
?>