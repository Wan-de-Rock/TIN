const artists = [];
 
module.exports= class Artist{
 
    constructor(name, numberOfMembers){
        this.name = name;
        this.numberOfMembers = numberOfMembers;
    }
    save(){
        artists.push(this);
    }
    static getAll(){
        return artists;
    }
}