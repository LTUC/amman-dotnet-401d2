class Library:
    def __init__(self, listOfBooks):
        self.availableBooks = listOfBooks

    def displayAvailableBooks(self):
        print()
        print("Available books")
        for book in self.availableBooks:
            print(book)

    def lendBook(self, requestBook):
        if requestBook in self.availableBooks:
            print("You have now borrowed the book")
            self.availableBooks.remove(requestBook)
        else:
            print("Sorry, the book is not available")

    def addBook(self, returnedBook):
        self.availableBooks.append(returnedBook)
        print("You have returned the books. Thank you!")

class Customer:
    def requestBook(self):
        print("Enter the name of the book you would like to borrow: ")
        self.book = input()
        return self.book

library = Library("Magical Me","Fantastic Beasts and where to find them", "Hogwarts, a history", "Year with the Yeti" )
customer = Customer()

while True:
    print("Enter 1 to display the available books")
    print("Enter 2 to request for a book")
    print("Enter 3 to return a book")
    print("Exit")
    userchoice = int(input())
    if userChoice is 1:
        #the Logic of the dispaly books is encapsulated. 
        # You don't know what is going on, but you really dont care, as long as the 
        # the expected behavior occurs
        library.displayAvailableBooks()
    if userChoice is 2:
        requestedBook = customer.requestBook()
        library.lendBook(requestedBook)
    if userChoice is 3:
        returnedBook = customer.requestBook()
        library.addBook(returnedBook)
    if userChoice is 4:
        quit()



