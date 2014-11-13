public class Selfie : Instagram{
    
    public string  gender       { get; set; }
    public bool    areYoufamous { get; set; }
    public bool    showBoobs    { get; set; }
    private int    like ;
    private int    barzoCount = 50;
   

    public Selfie(){
        this.gender = gender;
        this.areYoufamous = areYoufamous;
        this.showBoobs = showBoobs;
    }
    
    
    public void takePhoto() {
        Console.WriteLine("Click!");

        if ((gender == "male") || (gender == "man") && (areYoufamous = false)){
            like = 7; 
            //just best friends.
        }
       
        else if ((gender == "male") || (gender == "man") && (areYoufamous = true)){
            like = 300 - barzoCount;//they hating.

        }
       
        else if ((gender == "female") || (gender == "woman") ){
            
            if       (areYoufamous = false){like = 20;}
            else  if (areYoufamous = true) {like = 700;}
           
            while (showBoobs && barzoCount < 150){
                like += barzoCount;
                barzoCount++;
            }
            
        }

        else { Console.WriteLine("Go away fuckin faggot."); takePhoto(); }
        
    }

  
}