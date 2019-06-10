class Persona:
    def __init__(self, edad,nombre):
        self.edad=edad
        self.nombre = nombre
        print ("Se ha creado a",self.nombre,"de",self.edad)

    def hablar(self,*palabras):
        for frase in palabras:
           print (self.nombre,":",frase)
class Deportista(Persona):
    
    def __init__(self,edad,nombre,deporte):
        self.edad=edad
        self.nombre=nombre
        self.deporte=deporte
        print("Se ha creado a",self.nombre,"de",self.edad)
    def practicaDeporte(self):
        print (self.nombre,":Voy a practicar")

juan = Persona(30,"Juan")
juan.hablar("Hola, estoy hablando","Este soy yo")
luis = Deportista(18,"Luis","natacion")
luis.hablar("Hola, estoy hablando","Este soy yo")
luis.practicaDeporte()
print ("Luis practica",luis.deporte)