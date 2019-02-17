function findRepetitiveChars(input) {
    var repetitiveChars = new Array();
    var arr = input.split('');
    for (var i = 0; i < arr.length; i++) {
        for (var j = arr.length - 1; j > i; j--) {
            if (arr[i] == arr[j]) {
                repetitiveChars.push(arr[i]);
                break;
            }
        }
    }
    return repetitiveChars;
}

button.onclick = function () {
    var oldString;
    var words;
    oldString = inputText.value;
    alert("open console to see the result");
    var words = oldString.split(' ');
    var repChars = findRepetitiveChars(words[0]);
    var tmp;
    for (var i = 1; i < words.length; i++) {
        tmp = repChars.concat(findRepetitiveChars(words[i]));
        repChars = tmp;
    }
    console.log("repetitive chars:");
    console.log(repChars);
    var newString = words.map(function (word) {
        letters = word.split('');
        for (var i = 0; i < repChars.length; i++) {
            for(var j = 0; j < letters.length; j++){
                while(letters[j] == repChars[i]){
                    letters.splice(j, 1);
               }
            }
        }
            return letters.join('');
    }).join(' ');
    console.log("your old string:");
    console.log(oldString);
    console.log("new string:");
    console.log(newString);
};




