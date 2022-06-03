const EventEmitter = require('events'); // class 

var url = 'http://mylogger.io/log'; // this is a made up url. is it here to show that this is what would be needed in real-world Node app?


class Logger extends EventEmitter {
    //when we difine a function inside a class, we don't need the function key word, 
    //so the word function can be omitted from a function when it's inside of a class.  
    //and when a function is inside a class, we refer to it as a method. 
    /* function */ log(message) {
        //send an HTTP request
        console.log(message);
    
        //Raise an event (if we didn't have the listener, nothing would happen as a result of this.)
        this.emit('messageLogged', {id: 1, url: 'http://'}); //emit of course means to make a noise, or produce something. 
    }

}

module.exports = Logger;
