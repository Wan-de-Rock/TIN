const express = require('express');
const bodyParser = require('body-parser');
const ejs = require('ejs');
const fs = require('fs');
const app = express();

app.use(bodyParser.urlencoded({ extended: true }));

app.get('/', (req, res) => {
  res.render('index');
});

app.post('/', (req, res) => {
  const data = req.body.data;
  fs.writeFile('message.txt', data, err => {
    res.statusCode = 302;
    res.setHeader('Location', '/');
    return res.end();
  });
});

app.set('view engine', 'ejs');

app.listen(3000, () => {
  console.log('Server started on port 3000');
});
