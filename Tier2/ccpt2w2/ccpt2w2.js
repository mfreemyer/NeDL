async function getDefinitions() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;
    alert(apiString);

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    
    // fnally, print the response
    document.getElementById("wordDefinitions").innerHTML = ""; // clear what was previously shown
    

    var jsonData = await response.json(); // read the response as JSON



    // stringify and print out the JSON object in the RawData section
    document.getElementById("wordDefinitions").innerHTML = JSON.stringify(jsonData);

    // loop through the JSON object one paragraph at a time and print each 
    // LOOK INTO USING flatMap. 
    for (var para in jsonData) {
        document.getElementById("wordDefinitions").innerHTML += "<p>" + jsonData[para] + "</p?";
    }

    return true;



}