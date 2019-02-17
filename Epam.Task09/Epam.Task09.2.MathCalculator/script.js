function solveProblem(problem) {
    var numbers = problem.split(/[+\-*\/=\s]+/).filter(Number);
    var operators = problem.split(/[^+\-=*\/]+/).filter(Boolean);
    var result =  +numbers[0];
    var temp = 0;
    for (var i = 1; i < numbers.length; i++) {
        switch (operators[temp]) {
            case '+':
                result += +numbers[i];
                break;
            case '*':
                result *= +numbers[i];
                break;
            case '/':
                result /= +numbers[i];
                break;
            case '-':
                result -= +numbers[i];
                break;
        }
        temp++;
    }
    return result;
}
button.onclick = function () {
    var pr = inputText.value;
    alert(pr + solveProblem(pr).toFixed(2));
}
