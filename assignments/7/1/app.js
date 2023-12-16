const http = require("http");
const fs = require("fs");

http.createServer(async (request, response) => {

  if (request.url === "/submit") {

    let message = "";
    request.on("data", chunk => {
      message += chunk;
    });
    /*
    const buffers = []; // буфер для получаемых данных

    for await (const chunk of request) {
      buffers.push(chunk);        // добавляем в буфер все полученные данные
    }
    //buffers = buffers.replace("+", " ")
    const buff = buffers.join(";");
    console.log(buff);
    */
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