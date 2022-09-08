//clase principal
public class Libro 
//declara las variable
//declara la variable isbn y paginas como entero

{ private int ISBN,páginas;
//declara la variable titulo y autor como alfanumerioco
private string Titulo="",autor="";
  //guarda en la variable titulo
   public void gettitulo()
   
   {
        Console.WriteLine(this.Titulo);
    }
    // lama la variable titulo
public void settitulo(string nombrel){
        this.Titulo=nombrel;
}
// guarda en la variable autor
    public void getautor(){
        Console.WriteLine(this.autor);
    }
    //lama la variable autor
public void setautor(string nombrea){
        this.autor=nombrea;
}
// guarda la variable isbn
    public void getIBSN(){
        Console.WriteLine(this.ISBN);
    }
    //llama la variable ibsn
public void setIBSN(int ncode){
        this.ISBN=ncode;
}
//guarda la variable paginas
    public int getnpages(){
        return this.páginas;
    }
    //llama la variable paginas
public void setnpages(int npagi){
        this.páginas=npagi;
}     
   // escribe El libro con ISBN creado por el autor tiene páginas
  public void tostring(){ Console.WriteLine("El libro "+this.Titulo+" con ISBN "+this.ISBN+" creado por el autor "+this.autor+" tiene "+this.páginas+" páginas.");
  }
}