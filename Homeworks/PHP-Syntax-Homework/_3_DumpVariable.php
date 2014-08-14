<?php
    $variable = (object)[2,34];
    $dataType = gettype($variable);
    if($dataType == 'integer' || $dataType == 'double') {
        var_dump($variable);
    }
    else {
        echo($dataType);
    }
?>