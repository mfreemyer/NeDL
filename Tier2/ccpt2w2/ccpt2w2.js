async function getDefinition() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";
    

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;
    alert(apiString);

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    
    // fnally, print the response
    document.getElementById("wordDefinition").innerHTML = ""; // clear what was previously shown
    alert("so far so good!")

    var jsonData = await response.json(); // read the response as JSON

    // stringify and print out the JSON object in the RawData section
    document.getElementById("wordDefinition").innerHTML = JSON.stringify(jsonData);

    return true;





    // finally, have fun with the data



}