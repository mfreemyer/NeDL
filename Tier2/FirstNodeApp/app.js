
//Note that the naming convention of EventEmitter indicates that it's a class 
//as opposed to a function or simple value. 
//A class is a container for properties and functions which we call methods. 
//So a class is a container for a bunch of related methods and properties.
const EventEmitter = require('events'); // class 


const Logger = require('./logger');
const logger = new Logger();

//Register a listener. A listener is a function that will be called when that event is raised. 
//Here, we're saying, "hey, logger, when you raise this messageLogged event, I want to execute this code."
logger.on('messageLogged', (arg) => { // event arg can be called anything, but see notes for good practice.
    console.log('Listener called. This message comes from EventEmitter in app.js', arg);
});

logger.log('This is a message produced by the log function.');

//because we're using the same logger object for registering an event listener and also raising an event, 
//we're going to see both messages on the console. 
