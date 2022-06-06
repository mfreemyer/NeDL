//as a best practice, put all require calls at the top of the file so the dependencies of the module can be easily identified. 
const Joi = require('joi'); //the reason for the uppercase J is that what is returned from this module is a class. 
const express = require('express');
const { invalid } = require('joi');
const { response } = require('express');
const app = express();

app.use(express.json()); //adding a piece of middleware. we call app.use to use that middleware in the request processing pipeline. 

const courses = [
    {id: 1, name: 'course1'},
    {id: 2, name: 'course2'},
    {id: 3, name: 'course3'},
]
app.get('/', (req, res) => { // this is how we specify the route. we specify the path and a callback function is also called a route handler.
    res.send('Hello World!!!');
});

//endpoint to get all the courses (this one returns the courses array)
app.get('/api/courses', (req, res) => {
    res.send(courses);
});

//endpoint to get a single course
app.get('/api/courses/:id', (req, res) => {
    const course = courses.find(c => c.id === parseInt(req.params.id)); //find is a method that's available on every array in js
    if (!course) res.status(404).send('The course with the given ID was not found.')
    res.send(course);
});

app.post('/api/courses', (req, res) => {
    const schema = Joi.object({
        name: Joi.string()
        .min(3)
        .max(30)
        .required()
    });

    const result = schema.validate(req.body);

    /* Joi.validate(req.body, schema);
    console.log(result); */

    if (result.error) {
        // 400 Bad Request
        res.status(400).send(result.error.details[0].message);
        return;
    }
    
    const course = {
        id: courses.length + 1, // in the future when working with a db, the id will be assigned by the db so we wouldn't do it this way. 
        name: req.body.name
    };
    courses.push(course);
    res.send(course);
});


app.put('/api/courses/:1d'), (req, res) => {
    // look up the course
    // if not existing, return 404
    const course = courses.find(c => c.id === parseInt(req.params.id)); //find is a method that's available on every array in js
    if (!course) res.status(404).send('The course with the given ID was not found.')

    // validate
    // if invalid, return 400 - bad request
    const schema = Joi.object({
        name: Joi.string()
        .min(3)
        .max(30)
        .required()
    });

    const result = schema.validate(req.body);
    if (result.error) {
        // 400 Bad Request
        res.status(400).send(result.error.details[0].message);
        return;
    }

    // update course
    course.name = req.body.name; 
    // return the updated course
    response.send(course);

}

function validateCourse(course) {
    const schema = Joi.object({
        name: Joi.string()
        .min(3)
        .max(30)
        .required()
    });

    return schema.validate(course, schema);
}


// PORT 
const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));