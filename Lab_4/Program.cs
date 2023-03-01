
//Start by implementing two class hierarchies by declaring the classes with correct inheritance
//relationship.You don’t need to add any methods to these as we won’t need methods in
//these classes. First, hierarchy of Edible things:
//• ChewingGum and Food are Edible things.
//• Soup, Sandwich, Sweets are Food.
//• GrilledCheese and BahnMi are kinds of sandwiches.
//• IceCream, Waffles, Chocolate, CandyBar are Sweets.


//Edible hierarchy
public class Edible { }
public class ChewingGum : Edible { }
public class Food : Edible { } 

//Food
public class Soup : Food { }
public class Sandwich : Food { }
public class Sweets : Food { }

// Sammich
public class GrilledCheese : Sandwich { }
public class BahnMi : Sandwich { }

//Sweets
public class IceCream : Sweets { }
public class Waffles : Sweets { }
public class Chocolate : Sweets{ }
public class CandyBar : Sweets { }

//And a hierarchy of Payments:
//• Cash, Card, Swish, and Bitcoin are Payments.
//• EUR, USD, SEK are kinds of Cash
//Payment hierarchy
public class Payments { }
public class Cash : Payments { }
public class Card : Payments { }

    public class Swish : Payments { }
public class Bitcoin : Payments { }

public class EUR : Cash { }
public class USD : Cash { }
public class SEK : Cash { }

public abstract class 