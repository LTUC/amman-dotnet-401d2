class Coral:

    def community(self):
        print("Coral lives in a community.")


class Anemone:

    def protect_clownfish(self):
        print("The anemone is protecting the clownfish.")


class CoralReef(Coral, Anemone):
    pass


# Instantiate a Coral reef and see the multiple inheritance

great_barrier = CoralReef()
great_barrier.community()
great_barrier.protect_clownfish()