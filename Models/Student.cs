public class Student {
    public int StudentId {get;set;}
    public string StudentName {get;set;}
    public string StudentEmail {get;set;} = "";
    // index = "231539" -> mora me pasen
    // image = "/aws.com/images/container/pfp.png" -> mund te jet e zbrazet
    public required string Index {get;set;}
    public string ProfilePic {get;set;} = "";
}   