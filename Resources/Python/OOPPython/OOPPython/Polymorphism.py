# Polymorphism within a function

class Bear():
    def sound(self):
        print("Groarrr")
 
class Dog():
    def sound(self):
        print("Woof woof!")
 
def makeSound(animalType):
    animalType.sound()
 
 
bearObj = Bear()
dogObj = Dog()
 
makeSound(bearObj)
makeSound(dogObj)



#Polymorphism wihtin an abstract class
# Except abstract classes don't really exist in Python.
class Document:
    def __init__(self, name):    
        self.name = name
 
    def show(self):             
        raise NotImplementedError("Subclass must implement abstract method")
 
class Pdf(Document):
    def show(self):
        return 'Show pdf contents!'
 
class Word(Document):
    def show(self):
        return 'Show word contents!'
 
documents = [Pdf('Document1'),
             Pdf('Document2'),
             Word('Document3')]
 
for document in documents:
    print(document.name + ': ' + document.show())
