<DOCTYPE html>
<html>
    <head>
        <title>Get form data</title>
        <style>
            input {
                display: block;
            }
            #male, #female{
                display: inline-block;
            }
            #wrapper {
                display: block;
            }
        </style>
    </head>
    <body>
        <form>
            <input type="text" name="name" placeholder="Name...">
            <input type="number" name="age" placeholder="Age...">
            <div id="wrapper">
                <input type="radio" name="gender" id="male" value="male">
                <label for="male" id="firstLabel">Male</label>
            </div>
            <div id="wrapper">
                <input type="radio" name="gender" id="female" value="female">
                <label for="female">Female</label>
            </div>
            <input type="submit">
        </form>
        <?php
            $name = htmlentities($_GET['name']);
            $age = htmlentities($_GET['age']);
            $gender = htmlentities($_GET['gender']);
            echo "My name is $name" . ". " . "I am $age years old." . " I am $gender";
        ?>
    </body>
</html>