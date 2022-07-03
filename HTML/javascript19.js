function phoneticLookup(val){
    var result ="";
    var lookup = {
        "alpha" : "Adams",
        "bravo" : "boston",
        "charlie" : "chicago",
        "delta" : "denver",
        "echo" : "easy",
        "foxtrot" : "frank"
    };
    result = lookup[val];
    return result;
}
console.log(phoneticLookup("charlie"));