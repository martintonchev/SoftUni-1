<?php
    $name = "Traqn";
    $phoneNumber = "0887-751-151";
    $age = 26;
    $address = "Krasna Polqna";

?>
<DOCTYPE html>
<html>
    <head>
        <title>HTML - Table</title>
        <style>
            table {
                text-indent: 5px;
                border-collapse: collapse;
            }
            table tr {
                border: 1px solid #000;
            }
            table th, table td {
                width: 105px;
                line-height: 25px;
            }
            table th {
                text-align: left;
                background: #FFA100;
            }
            table td {
                text-align: right;
            }
        </style>
    </head>
    <body>
        <table>
            <tr>
                <th>
                    <strong>Name</strong>
                </th>
                <td>
                    <?php
                        echo($name);
                    ?>
                </td>
            </tr>
            <tr>
                <th>
                    <strong>Phone number</strong>
                </th>
                <td>
                    <?php
                        echo($phoneNumber);
                    ?>
                </td>
            </tr>
            <tr>
                <th>
                    <strong>Age</strong>
                </th>
                <td>
                    <?php
                        echo($age);
                    ?>
                </td>
            </tr>
            <tr>
                <th>
                    <strong>Address</strong>
                </th>
                <td>
                    <?php
                        echo($address);
                    ?>
                </td>
            </tr>
        </table>
    </body>
</html>