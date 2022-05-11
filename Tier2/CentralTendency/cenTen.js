function validateAndAdd() {
    // put the values from the form into variables
    var theNewMin = document.forms["myForm"]["minValue"].value;
    var theNewMax = document.forms["myForm"]["maxValue"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value;

    // validate that something was entered for minimum
    if (theNewMin == "") {
        alert("Please enter a minimum value");
        return false; // the gives a method result and ends the method
    }

    // validate that something was entered for the maximum
    else if (theNewMax == "") {
        alert("Please enter a maximum value");
        return false;
    }

    // validate that the max is higher than the min
    else if (theNewMin >= theNewMax) {
        alert("The minumum number must be less than the maximum number.");
        return false;
    }

    // validate that something was entered for the number and that any number entered is within range
    else if ((parseInt(theNewNumber) == "") || (parseInt(theNewNumber) < parseInt(theNewMin)) || (parseInt(theNewNumber) > parseInt(theNewMax))) {
        alert("Please ensure that you have entered a number to add and that it is within your specified range.");
        return false;
    }

    // now that valid entries have been entered, add them to the list and... 
    else {
        var tableRef = document.getElementById("numberList"); // this is getting numberList from the html file and assigning it to var tableRef. 
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewNumber // this is inserting a row into the table (that's now tableRef) 
                                                                                //and putting theNewNumber in the row
        

        // calculate and display the mean
        var sum = 0;
        var count = tableRef.rows.length // count 
        for (aRow = 0; aRow < count; aRow++) { // go through each row/number in the table
            sum += parseInt(((tableRef.rows[aRow]).innerHTML)); // adds the number in the row in the table to the sum. need to break this down.
        }
        var theAverage = sum/count; // calculate the mean
        var labelRef1 = document.getElementById("theMean");
        labelRef1.innerHTML = theAverage.toFixed(5); // this shows the mean to the user. need to break this down and understand it. 
    }

}