const Artist = require("../models/artist");

exports.addArtist = function (request, response){
    response.render("create.hbs");
};
exports.getArtists = function(request, response){
    response.render("artists.hbs", {
        artists: Artist.getAll()
    });
};

exports.postArtist= function(request, response){
    const artistname = request.body.name;
    const artistMembers = request.body.numberOfMembers;
    const artist = new Artist(artistname, artistMembers);
    artist.save();
    response.redirect("/artists");
};