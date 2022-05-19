async function getDefinitions() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord/*  + "/" + "meanings" */;
    /* alert(apiString); */

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    
    // fnally, print the response
    document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
    

    var jsonData = await response.json(); // read the response as JSON
    


    // stringify and print out the JSON object in the RawData section  -- don't need this since not looking to print raw data
    /* document.getElementById("wordData").innerHTML = JSON.stringify(jsonData); */

    // loop through the JSON object one meaning at a time and print each 
    // *** could do if statement for example, do for loop for multiple definitions ***

    for (var aWord in jsonData) {
        let numMeanings = jsonData[aWord].meanings.length;
        for (var aMeaning  = 0; aMeaning < numMeanings; aMeaning++) {
            document.getElementById("wordData").innerHTML += "<p>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</p>";
            
            let numDefinitions = jsonData[aWord].meanings[aMeaning].definitions.length;
            for (var aDefinition = 0; aDefinition < numDefinitions; aDefinition++) {
                document.getElementById("wordData").innerHTML += "<p>" + jsonData[aWord].meanings[aMeaning].definitions[aDefinition].definition + "</p>";
            }

        }
        
    }


    /* var theNewDefinition = "";
    for (var aDefinition in jsonData) {
          theNewDefinition += "<p><a href=" + jsonData[aDefinition].html_url + ">" + jsonData[aDefinition].theWord + "</a></p>";
        }
        
        document.getElementById("word").innerHTML = theWord;
        document.getElementById("wordData").innerHTML = theNewDefinition;
        alert("so far so good!");
        document.getElementById("word").value = ""; */
        


    return true;



}