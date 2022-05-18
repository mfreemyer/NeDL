async function getDefinitions() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord/*  + "/" + "meanings" */;
    alert(apiString);

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    
    // fnally, print the response
    document.getElementById("wordDefinitions").innerHTML = ""; // clear what was previously shown
    

    var jsonData = await response.json(); // read the response as JSON
    /* word[0].meanings[0].definitions[0].definition */


    // stringify and print out the JSON object in the RawData section
    document.getElementById("wordDefinitions").innerHTML = JSON.stringify(jsonData);

    // loop through the JSON object one paragraph at a time and print each 
    // *** LOOK INTO USING flatMap. 

    
    for (var aDefinition in jsonData) {
        document.getElementById("wordDefinitions").innerHTML += "<p>" + jsonData[aDefinition] + "</p>";
    }


    /* var theNewDefinition = "";
    for (var aDefinition in jsonData) {
          theNewDefinition += "<p><a href=" + jsonData[aDefinition].html_url + ">" + jsonData[aDefinition].theWord + "</a></p>";
        }
        
        document.getElementById("word").innerHTML = theWord;
        document.getElementById("wordDefinitions").innerHTML = theNewDefinition;
        alert("so far so good!");
        document.getElementById("word").value = ""; */
        


    return true;



}