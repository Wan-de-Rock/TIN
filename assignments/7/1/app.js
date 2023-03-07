const http = require("http");
const fs = require("fs");

http.createServer((request, response) => {

  if (request.url === "/submit") {

    let message = "";
    request.on("data", chunk => {
      message += chunk;
    });

    fs.readFile("views/submit.html", "utf8", function (error, data) {
      message = message.split('=')[1];
      data = data.replace("{message}", message);
      response.end(data);
    });
  }
  else {
    fs.readFile("views/index.html", (error, data) => response.end(data));
  }
}).listen(3000, () => console.log("Server started on port 3000"));