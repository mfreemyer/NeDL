const DICTIONARY_API_BASE_URL = 'https://api.dictionaryapi.dev/api/v2/entries/en/';
const DEFINITIONS_DIV = document.getElementById('definitions');

const fetchWordDefinitions = async word => {
    console.log(`Making request for definitions of ${word}...`);
    const response = await fetch(DICTIONARY_API_BASE_URL + word);
    const json = await response.json();
    return json[0].meanings
        .flatMap(m => m.definitions)
        .flatMap(d => d.definition);
};

const getWordDefinitions = () => {
    const word = document.getElementById('word').value;
    if (word == null || word == '') {
        return alert('Error: You must enter a word to fetch');
    }
    DEFINITIONS_DIV.innerHTML = '';
    fetchWordDefinitions(word)
        .then(defintions => {
            defintions.forEach(d => {
                DEFINITIONS_DIV.innerHTML += `<p>${d}</p>`;
            });
        })
        .catch(_ => {
            DEFINITIONS_DIV.innerHTML += `<p>Error: Could not retrive any defintions for ${word}.</p>`;
        });
};