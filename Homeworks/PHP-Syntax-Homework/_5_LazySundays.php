<?php
    $month = date("F");
    $year = date("Y");
    $totalDays = date("t");
    for($i = 0; $i < $totalDays; $i++) {
        $date = strtotime("$i $month $year");
        if(date("l", $date) == 'Sunday') {
            echo date('d F, Y', $date) . "\n";
        }
    }
?>