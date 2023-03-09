const fs = require('fs');

const artists = [];

module.exports = class Artist {

    constructor(name, numberOfMembers) {
        this.name = name;
        this.numberOfMembers = numberOfMembers;
    }
    save() {
        artists.push(this);
        //fs.appendFileSync('artistsDB.json', JSON.stringify(this));
        fs.writeFileSync('artistsDB.json', JSON.stringify(artists));
    }
    static getAll() {
        // TODO: fix first data enter
        try {
            return JSON.parse(fs.readFileSync('artistsDB.json'));
        } catch (error) {
            return artists;
        }
/*
        return JSON.parse(fs.readFileSync('artistsDB.json', (err, data) => {
            if (err)
                return artists;
        }));
        */
    }
}