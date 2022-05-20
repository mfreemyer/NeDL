async function getDefinitions() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);

    // now, check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <= 299) {  // valid status
    // fnally, print the response
    document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
    var jsonData = await response.json(); // read the response as JSON
    var dataHeading = document.getElementById("dataHeading");
    dataHeading.firstChild.nodeValue = "Definition(s) for " + theWord + ":";

    // loop through the JSON object one word, meaning, part of speech, definitions, and definition at a time and print each 
    // *** could do an if statement for printing keys that don't always have a value.
    for (var aWord in jsonData) {
        let numMeanings = jsonData[aWord].meanings.length;
        for (var aMeaning = 0; aMeaning < numMeanings; aMeaning++) {
            document.getElementById("wordData").innerHTML += "<h4>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</h4>";
            
            let numDefinitions = jsonData[aWord].meanings[aMeaning].definitions.length;
            for (var aDefinition = 0; aDefinition < numDefinitions; aDefinition++) {
                document.getElementById("wordData").innerHTML += "<ol start=1>" + jsonData[aWord].meanings[aMeaning].definitions[aDefinition].definition + "</ol>";
            }
        }  
    }
            /* alert("so far so good!"); */
            return true;
    }

    else {  // invalid status
        // Handle errors
        alert("No such word in dictionary. Try a different word. (error " + response.status + ")");
        theWord = "<p>Error accessing word, status: " + response.status + ": " + response.statusText;
        console.log(response.status, response.statusText);
    } 
}
 
// *****************************************************************
async function getSynonyms() {  
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    // now, check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <= 299) {  // valid status
        // fnally, print the response
        document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
        var jsonData = await response.json(); // read the response as JSON
        var dataHeading = document.getElementById("dataHeading");
        dataHeading.firstChild.nodeValue = "Synonym(s) for " + theWord + ":";  // *** got this from the interwebs to edit heading. study it more. ***

        // loop through the JSON object one word, meaning, part of speech, definitions, and definition at a time and print each 
        for (var aWord in jsonData) {
            let numMeanings = jsonData[aWord].meanings.length;
            for (var aMeaning = 0; aMeaning < numMeanings; aMeaning++) {
                if (jsonData[aWord].meanings[aMeaning].synonyms != "") {
                    document.getElementById("wordData").innerHTML += "<h4>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</h4>";
                    let numSynonyms = jsonData[aWord].meanings[aMeaning].synonyms.length;
                    /* if () */
                    for (var aSynonym = 0; aSynonym < numSynonyms; aSynonym++) {
                        document.getElementById("wordData").innerHTML += "<ol start=1>" + jsonData[aWord].meanings[aMeaning].synonyms[aSynonym] + "</ol>";
                    }
                }
                else {
                    document.getElementById("wordData").innerHTML += ""
                }
            }  
        }
                /* alert("so far so good!"); */
                return true;
    }
    else {  // invalid status
        // Handle errors
        alert("No such word in dictionary. Try a different word. (error " + response.status + ")");
        theWord = "<p>Error accessing word, status: " + response.status + ": " + response.statusText;
        console.log(response.status, response.statusText);
    }
}

// *****************************************************************
async function getAntonyms() {  
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    // now, check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <= 299) {  // valid status
        // fnally, print the response
        document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
        var jsonData = await response.json(); // read the response as JSON
        var dataHeading = document.getElementById("dataHeading");
        dataHeading.firstChild.nodeValue = "Antonym(s) for " + theWord + ":";  // *** got this from the interwebs to edit heading. study it more. ***

        // loop through the JSON object one word, meaning, part of speech, definitions, and definition at a time and print each 
        for (var aWord in jsonData) {
            let numMeanings = jsonData[aWord].meanings.length;
            for (var aMeaning = 0; aMeaning < numMeanings; aMeaning++) {
                if (jsonData[aWord].meanings[aMeaning].antonyms != "") {
                    document.getElementById("wordData").innerHTML += "<h4>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</h4>";
                    let numAntonyms = jsonData[aWord].meanings[aMeaning].antonyms.length;
                    /* if () */
                    for (var anAntonym = 0; anAntonym < numAntonyms; anAntonym++) {
                        document.getElementById("wordData").innerHTML += "<ol start=1>" + jsonData[aWord].meanings[aMeaning].antonyms[anAntonym] + "</ol>";
                    }
                }
                else {
                    document.getElementById("wordData").innerHTML += ""
                }
            }  
        }
                /* alert("so far so good!"); */
                return true;
        }
        else {  // invalid status
            // Handle errors
            alert("No such word in dictionary. Try a different word. (error " + response.status + ")");
            theWord = "<p>Error accessing word, status: " + response.status + ": " + response.statusText;
            console.log(response.status, response.statusText);
        }
}

// *****************************************************************
// *** not working properly yet! CIRCLE BACK TO THIS IF TIME
async function getPronunciation() { 
    // first build the API call string by starting with the URL
    var apiString = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    // next add the parameters to the string using the drop down lists
    var theWord = document.getElementById("word").value;
    apiString = apiString + theWord;

    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
    
    
    // now, check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <= 299) {  // valid status
        // fnally, print the response
        document.getElementById("wordData").innerHTML = ""; // clear what was previously shown
        var jsonData = await response.json(); // read the response as JSON
        var dataHeading = document.getElementById("dataHeading");
        dataHeading.firstChild.nodeValue = "Pronunciation(s) for " + theWord + ":";  // *** got this from the interwebs to edit heading. study it more. ***

        // loop through the JSON object one word, meaning, part of speech, definitions, and definition at a time and print each 
        // *** could do an if statement for printing keys that don't always have a value.
        for (var aWord in jsonData) {
            let numPhonetics = jsonData[aWord].phonetics.length;
            for (var aPhonetic = 0; aPhonetic < numPhonetics; aPhonetic++) {
                if (jsonData[aWord].meanings[aMeaning].phonetics != "") {
                document.getElementById("wordData").innerHTML += jsonData[aWord].phonetics[aPhonetic].text + ", ";
                }  
            }
        }

        /* for (var aWord in jsonData) {
            let numMeanings = jsonData[aWord].meanings.length;
            for (var aMeaning = 0; aMeaning < numMeanings; aMeaning++) {
                if (jsonData[aWord].meanings[aMeaning].text != "") {
                    document.getElementById("wordData").innerHTML += "<h4>" + jsonData[aWord].meanings[aMeaning].partOfSpeech + "</h4>";
                    alert(jsonData[aWord].meanings[aMeaning].phonetics);
                    document.getElementById("wordData").innerHTML += "<ol start=1>" + jsonData[aWord].meanings[aMeaning].text + "</ol>";
                    }
                }
            } */  

        return true;
    }
    else {  // invalid status
        // Handle errors
        alert("No such word in dictionary. Try a different word. (error " + response.status + ")");
        theWord = "<p>Error accessing word, status: " + response.status + ": " + response.statusText;
        console.log(response.status, response.statusText);
    }
}

function clearInput() {
    document.forms["wordForm"]["word"].value = ""; // clear the value that was entered
}