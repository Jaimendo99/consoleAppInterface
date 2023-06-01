// See https://aka.ms/new-console-template for more information
Person p1 = new Person("Jaime", "Aleman", 24);
Person p2 = new Person("Juan", "Mexicano", 25);


Console.WriteLine(p1.toString());

interface Human{
    public string name {get; set;}
    public string nacionalidad {get; set;}
    public int edad {get; set;}

    public string talk();
    public string toString();
}

class Person : Human{
    public string name {get; set;}
    public string nacionalidad {get; set;}
    public int edad {get; set;}

    public Person(string name, string nacionalidad, int edad){
        this.name = name;
        this.nacionalidad = nacionalidad;
        this.edad = edad;
    }

    public string talk(){
        return "Hola, mi nombre es " + this.name + " y tengo " + this.edad + " años";

    }

    public string toString(){
        return "Nombre: " + this.name + "\nNacionalidad: " + this.nacionalidad + "\nEdad: " + this.edad;
    }
}
