/* const exerciseArray = [];

addExercise() {
    exerciseArray = document.getElementById("addExercise").innerHTML
} */
    
{
    let exerciseArray = [];
    

    while(true){
        let input = prompt("Add a HIIT Exercise");
        if(input === "q" || input === null){
            break;
        }

        exerciseArray.push(Number(input));
        console.log(exerciseArray);

    }
}



