async function getDefinitions() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord/*  + "/" + "meanings" */;

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    // fnally, print the response
    document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
    var jsonData = await response.json(); // read the response as JSON

    // loop through the JSON object one word, meaning, part of speech, definitions, and definition at a time and print each 
    // *** could do an if statement for printing keys that don't always have a value.
    for (var aWord in jsonData) {
        let numMeanings = jsonData[aWord].meanings.length;
        for (var aMeaning  = 0; aMeaning < numMeanings; aMeaning++) {
            document.getElementById("wordData").innerHTML += "<h4>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</h4>";
            
            let numDefinitions = jsonData[aWord].meanings[aMeaning].definitions.length;
            for (var aDefinition = 0; aDefinition < numDefinitions; aDefinition++) {
                document.getElementById("wordData").innerHTML += "<ol start=1>" + jsonData[aWord].meanings[aMeaning].definitions[aDefinition].definition + "</ol>";
            }
        }  
    }
    document.getElementById("word").innerHTML = ""; // clear the value that was entered
    /* alert("so far so good!"); */
    return true;
}