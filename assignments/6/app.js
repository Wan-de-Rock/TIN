const http = require('http');
const url = require('url');
const server = http.createServer((req, res) => {
    const args = url.parse(req.url, true).query;

    var operation = args.function,
        x = parseInt(args.param1),
        y = parseInt(args.param2);

    res.setHeader('Content-Type', 'text/html');
    res.end(String(getResult(operation, x, y)));
}).listen(8080);

function getResult(operation, x, y) {
    switch (operation) {
        case 'add':
            return x + y;
        case 'sub':
            return x - y;
        case 'mul':
            return x * y;
        case 'div':
            return x / y;

        default:
            return 'error';
    }
}