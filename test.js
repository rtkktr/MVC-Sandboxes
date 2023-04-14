var output = 0;
var state = 0;

function show(event) {
    document.getElementById('display').value += event.target.value;
}



function changestate(event) {
    switch (event.target.value) {
        case '+':
            state = 1;
            break;
        case '-':
            state = 2;
            break;
        case '*':
            state = 3;
        break;
        case '/':
            state = 4;
            break;
        case '=':
            state = 5;
            break;
    }
}

function calculate(event) {
    
}