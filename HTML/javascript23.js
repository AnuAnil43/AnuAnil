var contacts = [
    {
        "firstName" : "Akira",
        "lastName"  :  "Latine",
        "number"    : "0543236543",
        "likes"     : ["Pizza","Coding","Brownie Points"]
     },
     {
        "firstName" : "Harry",
        "lastName"  :  "Potter",
        "number"    : "0543236543",
        "likes"     : ["Hogwarts","Magic","Hagrid"]
     }, 
     {
        "firstName" : "Sherlock",
        "lastName"  :  "Holmes",
        "number"    : "0543236543",
        "likes"     : ["Intriguing Cases","Violin"]
     },
     {
        "firstName" : "Kristain",
        "lastName"  :  "Vos",
        "number"    : "0543236543",
        "likes"     : ["Javascript","Gaming","Foxes"]
     }
];
function lookUpProfile(name, prop){
for (var i =0;i<contacts.length;i++){
    if(contacts[i].firstName === name) {
    return contacts[i][prop];
}
}
return "No such contact";

var data = lookUpProfile("Akira","likes");
console.log(data);
