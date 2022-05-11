function validateAndAdd() {
    // put the values in the form into the variables
    var theNewWord = document.forms["myForm"]["newWord"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value;
    // validate that something was entered for word
    if (theNewWord == "") {
        alert("Please enter a word to check.");
        return false;
    }
    // validate that the value entered is 1 or 2. tell user and clear the field if not
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
        alert("Please enter either 1 or 2.");
        document.forms["myForm"][newNumber].value = "";
        return false;
    }
    else {
        // since we now have valid data, add it to the proper table
        if (theNewNumber == 1) {
            var tableRef = document.getElementById("myList1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + PalindromeCheck1(theNewWord);

        }
        else {
            var tableRef = document.getElementById("myList2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord+ ': ' + PalindromeCheck2(theNewWord);
        }
        // erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
        }
    }

    function clearList1() {
        var tableRef = document.getElementById("myList1");
        tableRef.innerHTML = "";
    }

    function clearList2() {
        var tableRef = document.getElementById("myList2");
        tableRef.innerHTML = "";
    }

    function PalindromeCheck1(wordToCheck) {
        var wordFlip = wordToCheck.split("").reverse().join("");
        return wordToCheck === wordFlip;
    }

    function PalindromeCheck2(wordToCheck) {
        // find the length of a string
        const len = string.length;
        // loop through half of the string
        for (let i = 0; i < len / 2; i++) {
            // check if first and last string are same
            if (string[i] !== string[len - 1 - i]) {
                return ' is not a palindrome';
            }
        }
        return ' is a palindrome';
        }

    

