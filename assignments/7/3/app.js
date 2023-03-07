const express = require('express');
const bodyParser = require('body-parser');
const ejs = require('ejs');
const app = express();

app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(__dirname + '/public'));
app.set('view engine', 'ejs');

app.get('/', (request, response) => {
    response.render('index');
});

app.post('/submit', (request, response) => {
    if (!request.body) return response.sendStatus(400);

    response.render('submit', {
        name: request.body.name,
        surename: request.body.surename,
        age: request.body.age
    });
});

app.listen(3000, () => {
    console.log('Server started on port 3000');
});