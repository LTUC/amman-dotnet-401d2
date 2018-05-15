from Dog import Dog

# Child class (inherits from Dog class)
class RussellTerrier(Dog):
    def run(self, speed):
        return "{} runs {}".format(self.name, speed)


# Child class (inherits from Dog class)
class GoldenDoodle(Dog):
    def run(self, speed):
        return "{} runs {}".format(self.name, speed)


print("------")
print("From the Inheritance class")

# Child classes inherit attributes and
# behaviors from the parent class
sawyer = GoldenDoodle("Sawyer ", 4)
print(sawyer.description())

# Child classes have specific attributes
# and behaviors as well
print(sawyer.run("lightning fast"))