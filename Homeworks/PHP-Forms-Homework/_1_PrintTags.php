<!DOCTYPE html>
<html>
<head>
    <title>Print tags</title>
</head>
<body>
    <form action="<?php $PHP_SELF ?>" method="get">
        <label for="text">Enter Tags:</label><br/>
        <input type="text" id="text" name="tags">
        <input type="submit">
    </form>
    <?php
    if(isset($_GET['tags'])) {
        $inputString = $_GET["tags"];
        $tags = explode(", ", $inputString);
    }
    ?>
    <br/>;
    <?php
    for($i = 0; $i < count($tags); $i++) {
        echo $i . " : " .$tags[$i] . "<br/>";
    }
    ?>
</body>
</html>