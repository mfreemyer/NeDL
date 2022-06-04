

const http = require('http');

//createServer is one of the functions defined in the http module
/* const server = http.createServer(function(req, res) { 

}); */

//or we can use the arrow function syntax like so
const server = http.createServer((req, res) => {
    if (req.url === '/') {
        res.write('Hello World');
        res.end();
    }

    if (req.url === '/api/courses') {
        res.write(JSON.stringify([1, 2, 3])) //this will convert this array into a string using JSON syntax.
        res.end();
    }
}); 



server.listen(3000);

console.log('Listening on port 3000...')
//every time there is a new connection or new request, this server raises an event. 
//so we can use the on method to handle that event. 

//when we type localhost:3000 into browser, we can see in the console that we have a new connection