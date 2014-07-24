function checkBrackets() {
    var input = arguments[0];
    var brackets = 0;
    for(var br in input) {
        if(input[br] === '(') {
            brackets++;
        }
        else if(input[br] === ')') {
            brackets--;
        }
    }
    if(brackets === 0) {
        console.log('Correct');
    }
    else {
        console.log('Incorrect');
    }
}
checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');
